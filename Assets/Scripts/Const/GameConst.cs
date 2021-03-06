

using System.IO;
using UnityEngine;


public enum ENV_TYPE
{
    // 正式环境
    MASTER = 0,
    // 开发环境
    DEV = 1,

}
public class GameConst
{
    /// <summary>
    /// 运行环境
    /// </summary>
#if UNITY_EDITOR
    public static ENV_TYPE PRO_ENV = ENV_TYPE.DEV;
#else
    public static ENV_TYPE PRO_ENV = ENV_TYPE.MASTER;
#endif

    /// <summary>
    /// URL
    /// </summary>
#if UNITY_EDITOR
    public static string URL = "http://127.0.0.1";
#else
    public static string URL = "http://192.168.74.1";
#endif

    /// <summary>
    /// HTTP
    /// </summary>
    public static string HTTP = URL + ":300/";
    /// <summary>
    /// 下载网址
    /// </summary>
    public static string DOWNLOAD_URL = URL + ":80/Download/";

    /// <summary>
    /// Resources文件夹
    /// </summary>
    /// <returns></returns>
    public static string RESOURCES = Path.Combine(Application.dataPath, "./Resources");
    /// <summary>
    /// 本地 Res文件夹
    /// </summary>
    /// <returns></returns>
    public static string RES_LOCAL_ROOT = Path.Combine(Application.persistentDataPath, "./Res");
    /// <summary>
    /// Web Res文件夹
    /// </summary>
    /// <returns></returns>
    public static string RES_WEB_ROOT = Path.Combine(Application.dataPath, "../../card-server/web-server/public/Download");
    /// <summary>
    /// 打包根目录
    /// </summary>
    /// <returns></returns>
    public static string BUILD_ROOT = Path.Combine(Application.dataPath, "../Build");
    /// <summary>
    /// AB包打包目录
    /// </summary>
    /// <returns></returns>
    public static string BUILD_AB_ROOT = Path.Combine(Application.dataPath, "../AssetBundles");

    /// <summary>
    /// 下载临时文件夹 (断点传续用)
    /// </summary>
    public static string DOWNLOAD_TEMPFILE_ROOT = Path.Combine(Application.persistentDataPath, "./Temp");

    /// <summary>
    /// 获取相对路径
    /// </summary>
    public static string GetRelativePath(string filePath, string rootPath)
    {
        string result = Path.GetFullPath(filePath).Replace(Path.GetFullPath(rootPath) + "\\", "");
        return filePath == result ? null : result;
    }
}