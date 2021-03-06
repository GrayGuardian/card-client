using System.Linq;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Data;

public class ResTool : MonoBehaviour
{

    static void OpenFolder(string path)
    {
        path = new DirectoryInfo(path).FullName;
        if (!Directory.Exists(path))
        {
            if (UnityEditor.EditorUtility.DisplayDialog("提示", "文件夹不存在 是否创建？\n Url:" + path, "确定", "取消"))
            {
                Directory.CreateDirectory(path);
            }
            else
            {
                return;
            }
        }
        string arg = string.Format(@"/open,{0}", path);
        System.Diagnostics.Process.Start("explorer.exe", arg);
    }
    [MenuItem("Tools/资源管理/Open Folder/Build AssetBundles Folder")]
    static void OpenABFolder()
    {
        OpenFolder(GameConst.BUILD_AB_ROOT);
    }
    [MenuItem("Tools/资源管理/Open Folder/Build Folder")]
    static void OpenBuildFolder()
    {
        OpenFolder(GameConst.BUILD_ROOT);
    }
    [MenuItem("Tools/资源管理/Open Folder/Local Resource Folder")]
    static void OpenLocalResFolder()
    {
        OpenFolder(GameConst.RES_LOCAL_ROOT);
    }
    [MenuItem("Tools/资源管理/Open Folder/Web Resource Folder")]
    static void OpenWebResFolder()
    {
        OpenFolder(GameConst.RES_WEB_ROOT);
    }

    [MenuItem("Tools/资源管理/Build/Build")]
    static void BuildRes()
    {
        //准备工作
        var rootDir = new DirectoryInfo(GameConst.BUILD_ROOT);
        var rootABDir = new DirectoryInfo(Path.Combine(rootDir.FullName, "./AssetBundles"));
        var versionFile = new FileInfo(Path.Combine(rootDir.FullName, "./Version"));
        if (!Directory.Exists(rootABDir.FullName))
        {
            Directory.CreateDirectory(rootABDir.FullName);
            Debug.Log("Build - AB文件夹不存在，重新创建");
        }
        if (!Directory.Exists(rootDir.FullName))
        {
            Directory.CreateDirectory(rootDir.FullName);
            Debug.Log("Build文件夹不存在，重新创建");
        }
        foreach (var fileInfo in rootABDir.GetFiles())
        {
            //清空导出AB包文件
            fileInfo.Delete();
        }
        //构建资源
        List<ABVObject> abVObjectList = new List<ABVObject>();
        string[] blackFilesName = new string[] { "AssetBundles" };
        foreach (var file in new DirectoryInfo(GameConst.BUILD_AB_ROOT).GetFiles())
        {
            //Debug.Log(string.Format("文件路径：{0} 后缀名：{1} 文件名{2}",VARIABLE,Path.GetExtension(VARIABLE),Path.GetFileNameWithoutExtension(VARIABLE)) );
            //存在后缀名则跳过
            if (Path.GetExtension(file.FullName) == ".manifest")
            {
                continue;
            }
            //黑名单存在则跳过
            if (Array.IndexOf(blackFilesName, Path.GetFileName(file.FullName)) != -1)
            {
                continue;
            }
            var bytes = Util.Encrypt.AesEncrypt(Util.File.ReadBytes(file.FullName));
            var name = Path.GetFileNameWithoutExtension(file.FullName);
            var size = bytes.Length;
            var hash = Util.File.ComputeHash(bytes);

            //build AB File
            Util.File.WriteBytes(Path.Combine(rootABDir.FullName, name), bytes);
            Debug.Log(string.Format("Build AB Res >>>> name:{0} size:{1} hask:{2}", name, size, hash));

            //build version File
            abVObjectList.Add(new ABVObject() { name = name, size = size, hash = hash });
        }
        VObject vObject = new VObject();
        vObject.Version = "1.0.0";
        vObject.ClientVersion = Application.version;
        vObject.IsRestart = true;
        vObject.Content = "我是更新描述!";
        vObject.ABs = abVObjectList.ToArray();
        string json = vObject.toString();
        Debug.Log("Version Json:" + json);

        Util.Encrypt.WriteString(versionFile.FullName, json);

    }

    [MenuItem("Tools/资源管理/Build/Build ＆ CopyTo Local")]
    static void BuildRes1()
    {
        BuildRes();
        CopyResToLocalRoot();
    }
    [MenuItem("Tools/资源管理/Build/Build ＆ CopyTo Web")]
    static void BuildRes2()
    {
        BuildRes();
        CopyResToWebRoot();
    }
    [MenuItem("Tools/资源管理/Build/Build ＆ CopyTo Local ＆ CopyTo Web")]
    static void BuildRes3()
    {
        BuildRes();
        CopyResToLocalRoot();
        CopyResToWebRoot();
    }
    [MenuItem("Tools/资源管理/Copy/Copy To Local Folder")]
    static void CopyResToLocalRoot()
    {
        var rootDir = new DirectoryInfo(GameConst.RES_LOCAL_ROOT);
        CopyResToRoot(rootDir);
    }
    [MenuItem("Tools/资源管理/Copy/Copy To Web Folder")]
    static void CopyResToWebRoot()
    {
        var rootDir = new DirectoryInfo(GameConst.RES_WEB_ROOT);
        CopyResToRoot(rootDir);
    }
    [MenuItem("Tools/资源管理/Copy/Copy To Local Folder ＆ Web Folder")]
    static void CopyResToLocalRootAndWebRoot()
    {
        CopyResToLocalRoot();
        CopyResToWebRoot();
    }
    static void CopyResToRoot(DirectoryInfo rootDir)
    {
        string path;
        var rootBuildDir = new DirectoryInfo(GameConst.BUILD_ROOT);
        var rootABDir = new DirectoryInfo(Path.Combine(rootBuildDir.FullName, "./AssetBundles"));
        var versionFile = new FileInfo(Path.Combine(rootBuildDir.FullName, "./Version"));
        if (!Directory.Exists(rootDir.FullName))
        {
            Debug.Log("创建资源文件夹");
            Directory.CreateDirectory(rootDir.FullName);
        }
        if (!Directory.Exists(rootBuildDir.FullName))
        {
            UnityEditor.EditorUtility.DisplayDialog("提示", "Build文件夹不存在,请重新构建\n Url:" + rootBuildDir.FullName, "确定");
            return;
        }


        if (!File.Exists(versionFile.FullName))
        {
            UnityEditor.EditorUtility.DisplayDialog("提示", "Build - Version文件不存在,请重新构建\n Url:" + versionFile.FullName, "确定");
        }
        else
        {
            path = Path.Combine(rootDir.FullName, "./Version");
            versionFile.CopyTo(path, true);
            Debug.Log(string.Format("[{0}] Copy To >>> Path:{1}", "Version", path));
        }

        if (!Directory.Exists(rootABDir.FullName))
        {
            UnityEditor.EditorUtility.DisplayDialog("提示", "Build - AB文件夹不存在,请重新构建\n Url:" + rootABDir.FullName, "确定");
        }
        else
        {
            path = Path.Combine(rootDir.FullName, "./AssetBundles");
            if (!Directory.Exists(path))
            {
                Debug.Log("创建资源文件夹 - AB包");
                Directory.CreateDirectory(path);
            }
            else
            {
                foreach (var fileInfo in new DirectoryInfo(path).GetFiles())
                {
                    //清空导出AB包文件
                    fileInfo.Delete();
                }
            }
            foreach (var file in rootABDir.GetFiles())
            {
                file.CopyTo(Path.Combine(path, file.Name), true);
                Debug.Log(string.Format("AB - [{0}] Copy To >>> Path:{1}", file.Name, path));
            };

        }

    }
    // [MenuItem("Tools/资源管理/Print Version Json")]
    // static void PrintVersionJson()
    // {
    //     var versionFile = new FileInfo(Path.Combine(GameConst.BUILD_ROOT, "./Version"));
    //     if (!File.Exists(versionFile.FullName))
    //     {
    //         UnityEditor.EditorUtility.DisplayDialog("提示", "Build - Version文件不存在,请重新构建\n Url:" + versionFile.FullName, "确定");
    //         return;
    //     }
    //     string str = Util.Encrypt.ReadString(versionFile.FullName);
    //     Debug.Log(str);
    // }
    //需要导出的默认AB包资源
    static string[] DEFAULT_ABS = { "lua", "upres", "json" };
    [MenuItem("Tools/资源管理/Clear All Default_Res")]
    static void ClearAllDefaultRes()
    {
        DirectoryInfo rootDir = new DirectoryInfo(Path.Combine(GameConst.RESOURCES, "./Default"));
        foreach (var dir in rootDir.GetDirectories())
        {
            FileInfo[] files = dir.GetFiles();
            if (files.Length > 0)
            {
                foreach (var file in files)
                {
                    file.Delete();
                }
            }
            dir.Delete();
        }
        AssetDatabase.Refresh();
    }

    [MenuItem("Tools/资源管理/Copy All Default_Res To Resources")]
    static void CopyAllDefaultResToResources()
    {
        string root = Path.Combine(GameConst.RESOURCES, "./AB");
        foreach (var ab in DEFAULT_ABS)
        {
            FileInfo[] files;
            DirectoryInfo buildDir = new DirectoryInfo(Path.Combine(GameConst.RESOURCES, "./Default", "./" + ab));
            if (!Directory.Exists(buildDir.FullName))
            {
                //文件夹不存在 则创建
                Directory.CreateDirectory(buildDir.FullName);
            }
            else
            {
                //文件夹存在 则判断是否清理文件夹
                files = buildDir.GetFiles();
                if (files.Length > 0 && UnityEditor.EditorUtility.DisplayDialog("提示", "是否清空导出文件夹\n Url:" + buildDir.FullName, "确定", "取消"))
                {
                    foreach (var file in files)
                    {
                        file.Delete();
                    }
                }
            }


            //开始复制
            DirectoryInfo dir = new DirectoryInfo(Path.Combine(root, ab));
            files = Util.File.GetChildFiles(dir.FullName, "*");
            Dictionary<string, FileInfo> fileMap = new Dictionary<string, FileInfo>();
            foreach (var file in files)
            {
                if (fileMap.ContainsKey(file.Name))
                {
                    // Debug.LogError("Error:出现重复项：" + file.Name);
                    // return;
                }
                else
                {
                    fileMap.Add(file.Name, file);
                }
            }
            foreach (var file in fileMap.Values)
            {
                UnityEngine.Debug.Log(file.FullName);
                UnityEngine.Debug.Log(Path.Combine(GameConst.RESOURCES, "./Default", "./" + ab, "./" + file.Name));
                Util.File.CopyTo(file.FullName, Path.Combine(GameConst.RESOURCES, "./Default", "./" + ab, "./" + file.Name));
            }
        }
        AssetDatabase.Refresh();
    }

    [MenuItem("Tools/资源管理/Update ab_rely.json")]
    static void test()
    {
        var abRoots = new DirectoryInfo(Path.Combine(GameConst.RESOURCES, "./AB")).GetDirectories();

        JObject jObject = new JObject();

        foreach (var abRoot in abRoots)
        {
            string abName = abRoot.Name;
            string abPath = abRoot.FullName;
            FileInfo[] assetFileInfos = Util.File.GetChildFiles(abPath);

            JObject assets = new JObject();

            foreach (var assetFileInfo in assetFileInfos)
            {
                if (".mat|.anim|.prefab|.unity|.asset|.guiskin|.fontsettings|.controller".IndexOf(Path.GetExtension(assetFileInfo.FullName)) != -1)
                {
                    var relyAssetFilePaths = GetRelyAssetFilePaths(assetFileInfo.FullName);
                    if (relyAssetFilePaths.Length > 0)
                    {
                        List<string> relyABs = new List<string>();
                        foreach (var item in relyAssetFilePaths)
                        {
                            string ab = Regex.Match(item, @"Assets/Resources/AB/([_a-zA-Z0-9]+)/").Groups[1].Value;
                            if (ab != abName)
                            {
                                if (relyABs.IndexOf(ab) == -1)
                                {
                                    relyABs.Add(ab);
                                }

                            }
                        }
                        if (relyABs.Count > 0)
                        {
                            JArray arr = new JArray();
                            foreach (var ab in relyABs)
                            {
                                arr.Add(ab);
                            }

                            assets.Add(Path.GetFileNameWithoutExtension(assetFileInfo.FullName), arr);
                            jObject[abName] = assets;
                        }
                    }
                }
            }


        }

        string json = jObject.ToString();
        string filePath = Path.Combine(GameConst.RESOURCES, "./AB", "./json", "./ab_rely.json");
        Util.File.WriteString(filePath, json);
        Debug.Log("更新ab_rely.json>>>>>" + json);
    }
    /// <summary>
    /// 获取依赖资源文件路径集
    /// </summary>
    /// <returns></returns>
    static string[] GetRelyAssetFilePaths(string filePath, List<string> filePathList = null)
    {
        if (filePathList == null)
        {
            filePathList = new List<string>();
        }

        if (filePath.IndexOf("Assets/Resources/AB/") != -1 && filePathList.IndexOf(filePath) == -1)
        {
            filePathList.Add(filePath);
        }
        if (".mat|.anim|.prefab|.unity|.asset|.guiskin|.fontsettings|.controller".IndexOf(Path.GetExtension(filePath)) == -1)
        {
            return filePathList.ToArray();
        }


        string str = Util.File.ReadString(filePath);
        foreach (Match match in Regex.Matches(str, @"guid: (.+),"))
        {
            if (match.Groups.Count > 1)
            {
                string guid = match.Groups[1].Value;

                GetRelyAssetFilePaths(AssetDatabase.GUIDToAssetPath(guid), filePathList);
            }
        }

        return filePathList.ToArray();
    }
}