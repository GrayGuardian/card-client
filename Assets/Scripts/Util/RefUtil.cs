using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

/// <summary>
/// 更新数据
/// </summary>
public class RefData
{
    /// <summary>
    /// 更新类型
    /// 0 - 无需更新
    /// 1 - 客户端更新
    /// 2 - 首次打开下载资源
    /// 3 - 在线更新资源
    /// 4 - 版本文件不符，无需下载资源
    /// 5 - 文件损坏，需要更新
    /// </summary>
    public int type;
    /// <summary>
    /// 共计下载文件大小
    /// </summary>
    public int size;
    /// <summary>
    /// 更新数据
    /// </summary>
    public VObject data;
}
public class RefUtil
{
    public VObject Version
    {
        get
        {
            if (_vJson != "")
            {
                return JsonConvert.DeserializeObject<VObject>(_vJson);
            }
            return null;
        }
    }
    private string _vJson
    {
        get
        {
            string path = Path.Combine(GameConst.RES_LOCAL_ROOT, "Version");
            string json = Util.Encrypt.ReadString(path);
            return json;
        }
    }
    public VObject WebVersion
    {
        get
        {
            if (_webVersion == null)
            {
                string json = Util.Encrypt.AesDecrypt(Util.Http.Get(GameConst.DOWNLOAD_URL + "Version").content);
                _webVersion = JsonConvert.DeserializeObject<VObject>(json);
            }
            return _webVersion;
        }
    }
    private VObject _webVersion;

    /// <summary>
    /// 异步初始化远程版本文件
    /// </summary>
    public void WebVersionInit(Action<VObject> cb = null, Action errorCb = null)
    {
        Util.Http.Get_Asyn(GameConst.DOWNLOAD_URL + "Version", (result) =>
        {
            if (result.code == 200)
            {
                _webVersion = JsonConvert.DeserializeObject<VObject>(Util.Encrypt.AesDecrypt(result.content));
                if (cb != null) cb(_webVersion);
            }
        }, errorCb);
    }

    /// <summary>
    /// 更新版本文件
    /// </summary>
    public void UpVersion()
    {
        Debug.Log("更新版本文件>>" + WebVersion.toString());
        Util.Encrypt.WriteString(Path.Combine(GameConst.RES_LOCAL_ROOT, "Version"), WebVersion.toString());
    }
    /// <summary>
    /// 获取更新数据
    /// </summary>
    /// <returns></returns>
    public RefData GetRefData()
    {
        VObject data = JsonConvert.DeserializeObject<VObject>(WebVersion.toString());

        //校验AB包文件
        int sizeSum = 0;
        List<ABVObject> abList = new List<ABVObject>();
        foreach (var ab in WebVersion.ABs)
        {
            string path = Path.Combine(GameConst.RES_LOCAL_ROOT, "./AssetBundles", "./" + ab.name);
            byte[] bytes = Util.File.ReadBytes(path);
            string hash = Util.File.ComputeHash(bytes);
            long size = bytes.Length;
            if (hash != ab.hash || size != ab.size)
            {
                //判断是否存在缓存文件
                string tempPath = Path.Combine(GameConst.DOWNLOAD_TEMPFILE_ROOT, ab.name + "_" + ab.hash + ".temp");
                if (File.Exists(tempPath))
                {
                    //存在缓存文件
                    FileInfo tempFile = new FileInfo(tempPath);
                    ab.size = ab.size - (int)tempFile.Length;
                }
                sizeSum += ab.size;
                abList.Add(ab);
            }
        }
        data.ABs = abList.ToArray();

        int type = 0;
        if (data.ClientVersion != Application.version)
        {
            // 客户端更新
            type = 1;
        }
        else if (Version == null && data.ABs.Length > 0)
        {
            // 首次打开，需要下载资源
            type = 2;
        }
        else if ((Version == null || Version.toString() != WebVersion.toString()) && data.ABs.Length > 0)
        {
            // 在线下载资源更新
            type = 3;
        }
        else if ((Version == null || Version.toString() != WebVersion.toString()) && data.ABs.Length == 0)
        {
            // 版本文件不符，无需下载资源
            type = 4;
        }
        else if (data.ABs.Length > 0)
        {
            // 文件损坏，需要更新
            type = 5;
        }

        RefData refdata = new RefData();
        refdata.type = type;
        refdata.size = sizeSum;
        refdata.data = data;
        return refdata;
    }
    /// <summary>
    /// 清理冗余资源
    /// </summary>
    public void ClearRedundantRes()
    {
        DirectoryInfo dirInfo;
        // 清理临时文件
        dirInfo = new DirectoryInfo(GameConst.DOWNLOAD_TEMPFILE_ROOT);
        if (!Directory.Exists(dirInfo.FullName))
            return;
        foreach (var fileInfo in dirInfo.GetFiles())
        {
            fileInfo.Delete();
        }
        // 清理多余AB包文件
        List<string> abNameList = new List<string>();
        foreach (var ab in WebVersion.ABs)
        {
            abNameList.Add(ab.name);
        }
        dirInfo = new DirectoryInfo(Path.Combine(GameConst.RES_LOCAL_ROOT, "./AssetBundles"));
        foreach (var fileInfo in dirInfo.GetFiles())
        {
            if (abNameList.IndexOf(fileInfo.Name) == -1)
            {
                UnityEngine.Debug.Log("清理多余AB包文件>>" + fileInfo.Name);
                fileInfo.Delete();
            }
        }
    }
}