
using System.IO;
using LuaInterface;
public class LuaFileUtil : LuaFileUtils
{
    public static LuaFileUtil Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new LuaFileUtil();
            }

            return instance;
        }

        protected set
        {
            instance = value;
        }
    }

    protected static LuaFileUtil instance = null;

    public LuaFileUtil()
    {
        instance = this;
    }


    public override byte[] ReadFile(string fileName)
    {
        byte[] bytes = new byte[] { };

        if (bytes.Length == 0)
        {
            bytes = Util.Res.LoadBytes("lua", Path.GetFileNameWithoutExtension(fileName) + ".lua", true);
            if (bytes == null)
                bytes = new byte[] { };
        }
        return bytes;
    }
}
