using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json.Linq;
public class ResObject
{
    public string name;
    public UnityEngine.Object res;
}
public class ResUtil
{
    private Dictionary<string, byte[]> _abByteMap = new Dictionary<string, byte[]>();
    private Dictionary<AssetBundle, List<ResObject>> _abMap = new Dictionary<AssetBundle, List<ResObject>>();
    public string[] getABKeys()
    {
        FileInfo[] infos = Util.File.GetChildFiles(Path.Combine(GameConst.RES_LOCAL_ROOT, "./AssetBundles"));
        string[] keys = new string[infos.Length];
        for (int i = 0; i < infos.Length; i++)
        {
            keys[i] = infos[i].Name;
        }
        return keys;
    }
    public AssetBundle GetBundleByName(string name)
    {
        foreach (var bundle in _abMap.Keys)
        {
            if (bundle.name == name)
            {
                return bundle;
            }
        }
        return null;
    }

    public AssetBundle GetBundleByRes(UnityEngine.Object res)
    {
        foreach (var bundle in _abMap.Keys)
        {
            var ress = _abMap[bundle];
            foreach (var r in ress)
            {
                if (r.res == res)
                {
                    return bundle;
                }
            }
        }
        return null;
    }
    public AssetBundle[] GetBundlesByRes(UnityEngine.Object res)
    {
        List<AssetBundle> bundleList = new List<AssetBundle>();
        foreach (var bundle in _abMap.Keys)
        {
            var ress = _abMap[bundle];
            foreach (var r in ress)
            {
                if (r.res == res)
                {
                    bundleList.Add(bundle);
                }
            }
        }
        return bundleList.ToArray();
    }
    public ResObject GetResObjectByRes(UnityEngine.Object res)
    {
        foreach (var bundle in _abMap.Keys)
        {
            var ress = _abMap[bundle];
            foreach (var r in ress)
            {
                if (r.res == res)
                {
                    return r;
                }
            }
        }
        return null;
    }

    public ResObject GetResObjectByResName(string resName)
    {
        foreach (var bundle in _abMap.Keys)
        {
            var ress = _abMap[bundle];
            foreach (var r in ress)
            {
                if (r.name == resName)
                {
                    return r;
                }
            }
        }
        return null;
    }
    public ResObject GetResObjectByResName(AssetBundle bundle, string resName)
    {
        var ress = _abMap[bundle];
        foreach (var r in ress)
        {
            if (r.name == resName)
            {
                return r;
            }
        }
        return null;
    }
    public ResObject[] GetResObjectsByRes(UnityEngine.Object res)
    {
        List<ResObject> resList = new List<ResObject>();
        foreach (var bundle in _abMap.Keys)
        {
            var ress = _abMap[bundle];
            foreach (var r in ress)
            {
                if (r.res == res)
                {
                    resList.Add(r);
                }
            }
        }
        return resList.ToArray();
    }
    public string[] GetRelyABs(string key, string resName)
    {
        if (key == "json" && resName == "ab_rely") return new string[] { };
        List<string> relyABList = new List<string>();
        string json = Util.Res.LoadString("json", "ab_rely", true);
        JObject jObject = JObject.Parse(json);

        var temp = jObject[key];
        if (temp != null)
        {
            var jtoken = temp[resName];
            // UnityEngine.Debug.LogFormat("{0} {1} {2}", key, resName, jtoken);
            if (jtoken != null)
            {
                foreach (var ab in jtoken.Values<string>())
                {
                    relyABList.Add(ab);
                }
            }
        }

        return relyABList.ToArray();
    }
    public bool ExistAssetBundle(string key)
    {
        string filePath = Path.Combine(GameConst.RES_LOCAL_ROOT, "./AssetBundles", "./" + key);
        if (!File.Exists(filePath)) return false;
        return true;
    }
    public byte[] DecryptAssetBundle(string key)
    {
        string filePath = Path.Combine(GameConst.RES_LOCAL_ROOT, "./AssetBundles", "./" + key);
        if (!File.Exists(filePath)) return null;
        byte[] data = Util.Encrypt.ReadBytes(filePath);
        _abByteMap.Add(key, data);
        return data;
    }
    public void DecryptAssetBundleAsyn(string key, Action<byte[]> cb)
    {
        string filePath = Path.Combine(GameConst.RES_LOCAL_ROOT, "./AssetBundles", "./" + key);
        if (!File.Exists(filePath)) return;
        float time = Time.time;
        Util.Encrypt.ReadBytesAsyn(filePath, (data) =>
        {
            UnityEngine.Debug.Log(key + ">Time ??????>>" + (Time.time - time));
            _abByteMap.Add(key, data);
            cb(data);
        });
    }
    public AssetBundle LoadAssetBundle(string key)
    {
        if (GameConst.PRO_ENV != ENV_TYPE.MASTER) return null;
        AssetBundle bundle = GetBundleByName(key);
        if (bundle != null) return bundle;
        UnityEngine.Debug.Log("??????AB??????" + key);
        byte[] data = null;
        if (_abByteMap.ContainsKey(key))
        {
            data = _abByteMap[key];
        }
        else
        {
            data = DecryptAssetBundle(key);
        }
        if (data == null) return null;

        bundle = AssetBundle.LoadFromMemory(data);
        _abMap.Add(bundle, new List<ResObject>());

        return bundle;
    }

    public void LoadAssetBundleAsyn(string key, Action<AssetBundle> cb = null)
    {
        MonoSingleton.Instance.StartCoroutine(_loadAssetBundleAsyn(key, cb));
    }
    System.Collections.IEnumerator _loadAssetBundleAsyn(string key, Action<AssetBundle> cb = null)
    {
        if (GameConst.PRO_ENV != ENV_TYPE.MASTER)
        {
            yield break;
        }
        AssetBundle bundle = GetBundleByName(key);
        if (bundle != null)
        {
            if (cb != null) cb(bundle);
            yield break;
        }
        UnityEngine.Debug.Log("??????AB??????" + key);
        byte[] data = null;

        if (_abByteMap.ContainsKey(key))
        {
            data = _abByteMap[key];
        }
        else
        {
            if (!ExistAssetBundle(key))
            {
                yield break;
            }
            DecryptAssetBundleAsyn(key, (d) =>
            {
                data = d;
            });
        }

        yield return new WaitUntil(() => { return data != null; });
        float time = Time.time;
        var assetLoadRequest = AssetBundle.LoadFromMemoryAsync(data);
        yield return assetLoadRequest;
        UnityEngine.Debug.Log(key + ">Time ??????>>" + (Time.time - time));
        bundle = assetLoadRequest.assetBundle;

        _abMap.Add(bundle, new List<ResObject>());

        if (cb != null) cb(bundle);
    }
    public AssetBundle[] LoadAllAssetBundle()
    {
        List<AssetBundle> list = new List<AssetBundle>();
        string[] keys = getABKeys();
        foreach (var key in keys)
        {
            list.Add(LoadAssetBundle(key));
        }
        return list.ToArray();
    }
    public void LoadAllAssetBundleAsyn(Action<AssetBundle[]> cb)
    {
        List<AssetBundle> list = new List<AssetBundle>();
        string[] keys = getABKeys();
        foreach (var key in keys)
        {
            LoadAssetBundleAsyn(key, (b) =>
            {
                list.Add(b);
                if (list.Count >= keys.Length)
                    cb(list.ToArray());
            });
        }
    }
    public void UnLoadAssetBundle(string key, bool unloadAllLoadedObjects = false)
    {
        if (GameConst.PRO_ENV != ENV_TYPE.MASTER) return;
        AssetBundle bundle = GetBundleByName(key);
        if (bundle == null) return;
        if (!unloadAllLoadedObjects && _abMap[bundle].Count > 0)
        {
            return;
        }
        _abMap.Remove(bundle);
        UnityEngine.Debug.Log("??????AB??????" + key);
        bundle.Unload(unloadAllLoadedObjects);
    }
    public void UnLoadAllAssetBundle(bool unloadAllLoadedObjects = false)
    {
        string[] keys = getABKeys();
        foreach (var key in keys)
        {
            LoadAssetBundleAsyn(key, (b) =>
            {
                UnLoadAssetBundle(key, unloadAllLoadedObjects);
            });
        }
    }
    public UnityEngine.Object Load(Type type, string key, string resName, bool loadIsClose = false)
    {
        UnityEngine.Object res = default(UnityEngine.Object);
        if (GameConst.PRO_ENV == ENV_TYPE.MASTER)
        {
            AssetBundle bundle = GetBundleByName(key);
            if (bundle == null)
            {
                bundle = LoadAssetBundle(key);
            }
            if (bundle != null)
            {
                var relyABs = GetRelyABs(key, resName);

                List<AssetBundle> bundles = new List<AssetBundle>() { bundle };

                foreach (var ab in relyABs)
                {
                    if (ab != key)
                    {
                        AssetBundle b = LoadAssetBundle(ab);
                        if (b != null)
                        {
                            bundles.Add(b);
                        }
                        else
                        {
                            bundles.Add(GetBundleByName(ab));
                        }
                    }
                }

                res = bundle.LoadAsset(resName, type);
                if (res != default(UnityEngine.Object))
                {
                    // UnityEngine.Debug.Log(string.Format("??????AB??????????????? key:{0} resName:{1}", key, resName));
                    var resObject = new ResObject() { name = resName, res = res };
                    foreach (var b in bundles)
                    {

                        if (GetResObjectByResName(b, resName) == null)
                        {
                            _abMap[b].Add(resObject);
                        }

                    }

                    if (loadIsClose)
                    {
                        UnLoad(res);
                    }
                }
                foreach (var ab in relyABs)
                {
                    UnLoadAssetBundle(ab);
                }
            }
        }
        else
        {
            string resPath = Path.Combine(GameConst.RESOURCES, "./AB/" + key);
            FileInfo fileInfo = Util.File.GetChildFile(resPath, resName + ".*");
            if (fileInfo != null)
            {
                string dirPath = GameConst.GetRelativePath(fileInfo.DirectoryName, GameConst.RESOURCES);
                resPath = Path.Combine(dirPath, resName);
                res = Resources.Load(resPath, type);
                if (res != default(UnityEngine.Object))
                {
                    // UnityEngine.Debug.Log(string.Format("?????????AB???(Resources)???????????? key:{0} resName:{1} resPath:{2}", key, resName, resPath));
                }
            }
        }

        if (res == default(UnityEngine.Object))
        {
            res = Resources.Load("Default/" + key + "/" + resName, type);
            if (res != default(UnityEngine.Object))
            {
                // UnityEngine.Debug.Log(string.Format("????????????????????????????????? key:{0} resName:{1}", key, resName));
            }

        }
        if (res == default(UnityEngine.Object))
        {
            res = Resources.Load(key + "/" + resName, type);
            if (res != default(UnityEngine.Object))
            {
                // UnityEngine.Debug.Log(string.Format("??????Base????????????????????? key:{0} resName:{1}", key, resName));
            }
        }

        return res;
    }
    public void LoadAsyn(Type type, string key, string resName, Action<UnityEngine.Object> cb = null, bool loadIsClose = false)
    {
        MonoSingleton.Instance.StartCoroutine(_loadAsyn(type, key, resName, cb, loadIsClose));
    }
    System.Collections.IEnumerator _loadAsyn(Type type, string key, string resName, Action<UnityEngine.Object> cb = null, bool loadIsClose = false)
    {
        UnityEngine.Object res = default(UnityEngine.Object);
        if (GameConst.PRO_ENV == ENV_TYPE.MASTER)
        {
            AssetBundle bundle = GetBundleByName(key);
            if (bundle == null)
            {
                Debug.Log("????????? ????????????>>>" + key);
                yield return MonoSingleton.Instance.StartCoroutine(_loadAssetBundleAsyn(key, (val) => { bundle = val; }));
            }
            if (bundle != null)
            {
                var relyABs = GetRelyABs(key, resName);

                List<AssetBundle> bundles = new List<AssetBundle>() { bundle };

                foreach (var ab in relyABs)
                {
                    if (ab != key)
                    {
                        AssetBundle b = null;
                        yield return MonoSingleton.Instance.StartCoroutine(_loadAssetBundleAsyn(ab, (val) => { b = val; }));

                        if (b != null)
                        {
                            bundles.Add(b);
                        }
                        else
                        {
                            bundles.Add(GetBundleByName(ab));
                        }
                    }
                }

                var assetRequest = bundle.LoadAssetAsync(resName, type);
                yield return assetRequest;
                res = assetRequest.asset;
                if (res != default(UnityEngine.Object))
                {
                    UnityEngine.Debug.Log(string.Format("??????AB??????????????? key:{0} resName:{1}", key, resName));
                    var resObject = new ResObject() { name = resName, res = res };
                    foreach (var b in bundles)
                    {

                        if (GetResObjectByResName(b, resName) == null)
                        {
                            _abMap[b].Add(resObject);
                        }

                    }

                    if (loadIsClose)
                    {
                        UnLoad(res);
                    }
                }
                foreach (var ab in relyABs)
                {
                    UnLoadAssetBundle(ab);
                }
            }
        }
        else
        {
            string resPath = Path.Combine(GameConst.RESOURCES, "./AB/" + key);
            FileInfo fileInfo = Util.File.GetChildFile(resPath, resName + ".*");
            if (fileInfo != null)
            {
                string dirPath = GameConst.GetRelativePath(fileInfo.DirectoryName, GameConst.RESOURCES);
                resPath = Path.Combine(dirPath, resName);
                var assetRequest = Resources.LoadAsync(resPath, type);
                yield return assetRequest;
                res = assetRequest.asset;
                if (res != default(UnityEngine.Object))
                {
                    UnityEngine.Debug.Log(string.Format("?????????AB???(Resources)???????????? key:{0} resName:{1} resPath:{2}", key, resName, resPath));
                }
            }
        }

        if (res == default(UnityEngine.Object))
        {
            var assetRequest = Resources.LoadAsync("Default/" + key + "/" + resName, type);
            yield return assetRequest;
            res = assetRequest.asset;
            if (res != default(UnityEngine.Object))
            {
                UnityEngine.Debug.Log(string.Format("????????????????????????????????? key:{0} resName:{1}", key, resName));
            }

        }
        if (res == default(UnityEngine.Object))
        {
            var assetRequest = Resources.LoadAsync(key + "/" + resName, type);
            yield return assetRequest;
            res = assetRequest.asset;
            if (res != default(UnityEngine.Object))
            {
                UnityEngine.Debug.Log(string.Format("??????Base????????????????????? key:{0} resName:{1}", key, resName));
            }
        }

        if (cb != null) cb(res);
    }

    public void UnLoad(UnityEngine.Object res)
    {
        var bundles = GetBundlesByRes(res);
        var resObjects = GetResObjectsByRes(res);
        if (resObjects.Length == 0) return;
        foreach (var bundle in bundles)
        {
            var bundle_name = bundle.name;
            var ress = _abMap[bundle];
            foreach (var resObject in resObjects)
            {
                if (ress.Remove(resObject))
                {
                    if (ress.Count == 0)
                    {
                        UnLoadAssetBundle(bundle_name);
                    }
                }
            }

        }
    }
    public UnityEngine.Object Load(string key, string resName, bool loadIsClose = false)
    {
        UnityEngine.Object o = Load(typeof(UnityEngine.Object), key, resName, loadIsClose);
        return o;
    }
    public void LoadAsyn(string key, string resName, Action<UnityEngine.Object> cb = null, bool loadIsClose = false)
    {
        LoadAsyn(typeof(UnityEngine.Object), key, resName, cb, loadIsClose);
    }
    public string LoadString(string key, string resName, bool loadIsClose = true)
    {
        UnityEngine.Object o = Load(key, resName, loadIsClose);
        if (o == null) return null;
        return o.ToString();
    }
    public void LoadStringAsyn(string key, string resName, Action<string> cb = null, bool loadIsClose = true)
    {
        LoadAsyn(typeof(UnityEngine.Object), key, resName, (o) =>
        {
            string asset = null;
            if (o != null)
            {
                asset = o.ToString();
            }
            if (cb != null) cb(asset);
        }, loadIsClose);
    }

    public byte[] LoadBytes(string key, string resName, bool loadIsClose = true)
    {
        string str = LoadString(key, resName, loadIsClose);
        if (str == null) return null;
        return System.Text.Encoding.UTF8.GetBytes(str);
    }
    public void LoadBytesAsyn(string key, string resName, Action<byte[]> cb = null, bool loadIsClose = true)
    {
        LoadStringAsyn(key, resName, (str) =>
        {
            byte[] asset = null;
            if (str != null)
            {
                asset = System.Text.Encoding.UTF8.GetBytes(str);
            }
            if (cb != null) cb(asset);
        }, loadIsClose);
    }
    public Sprite LoadSprite(string key, string resName, bool loadIsClose = false)
    {
        return (Sprite)Load(typeof(Sprite), key, resName, loadIsClose);
    }
    public void LoadSpriteAsyn(string key, string resName, Action<Sprite> cb = null, bool loadIsClose = false)
    {
        LoadAsyn(typeof(Sprite), key, resName, (asset) =>
        {
            if (asset != null) cb((Sprite)asset);
        }, loadIsClose);
    }
    public GameObject LoadGameObject(string key, string resName, bool loadIsClose = false)
    {
        return (GameObject)Load(typeof(GameObject), key, resName, loadIsClose);
    }
    public void LoadGameObjectAsyn(string key, string resName, Action<GameObject> cb = null, bool loadIsClose = false)
    {
        LoadAsyn(typeof(GameObject), key, resName, (asset) =>
        {
            if (asset != null) cb((GameObject)asset);
        }, loadIsClose);
    }
    public RuntimeAnimatorController LoadAnimator(string key, string resName, bool loadIsClose = false)
    {
        return (RuntimeAnimatorController)Load(typeof(RuntimeAnimatorController), key, resName, loadIsClose);
    }
    public void LoadAnimatorAsyn(string key, string resName, Action<RuntimeAnimatorController> cb = null, bool loadIsClose = false)
    {
        LoadAsyn(typeof(RuntimeAnimatorController), key, resName, (asset) =>
        {
            if (asset != null) cb((RuntimeAnimatorController)asset);
        }, loadIsClose);
    }

}