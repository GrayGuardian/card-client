//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class RefUtilWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(RefUtil), typeof(System.Object));
		L.RegFunction("WebVersionInit", WebVersionInit);
		L.RegFunction("UpVersion", UpVersion);
		L.RegFunction("GetRefData", GetRefData);
		L.RegFunction("ClearRedundantRes", ClearRedundantRes);
		L.RegFunction("New", _CreateRefUtil);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Version", get_Version, null);
		L.RegVar("WebVersion", get_WebVersion, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateRefUtil(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				RefUtil obj = new RefUtil();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: RefUtil.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WebVersionInit(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				RefUtil obj = (RefUtil)ToLua.CheckObject<RefUtil>(L, 1);
				obj.WebVersionInit();
				return 0;
			}
			else if (count == 2)
			{
				RefUtil obj = (RefUtil)ToLua.CheckObject<RefUtil>(L, 1);
				System.Action<VObject> arg0 = (System.Action<VObject>)ToLua.CheckDelegate<System.Action<VObject>>(L, 2);
				obj.WebVersionInit(arg0);
				return 0;
			}
			else if (count == 3)
			{
				RefUtil obj = (RefUtil)ToLua.CheckObject<RefUtil>(L, 1);
				System.Action<VObject> arg0 = (System.Action<VObject>)ToLua.CheckDelegate<System.Action<VObject>>(L, 2);
				System.Action arg1 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 3);
				obj.WebVersionInit(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: RefUtil.WebVersionInit");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpVersion(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			RefUtil obj = (RefUtil)ToLua.CheckObject<RefUtil>(L, 1);
			obj.UpVersion();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRefData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			RefUtil obj = (RefUtil)ToLua.CheckObject<RefUtil>(L, 1);
			RefData o = obj.GetRefData();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearRedundantRes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			RefUtil obj = (RefUtil)ToLua.CheckObject<RefUtil>(L, 1);
			obj.ClearRedundantRes();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Version(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			RefUtil obj = (RefUtil)o;
			VObject ret = obj.Version;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Version on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_WebVersion(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			RefUtil obj = (RefUtil)o;
			VObject ret = obj.WebVersion;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index WebVersion on a nil value");
		}
	}
}

