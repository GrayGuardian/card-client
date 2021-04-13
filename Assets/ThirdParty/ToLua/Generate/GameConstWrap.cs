﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class GameConstWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(GameConst), typeof(System.Object));
		L.RegFunction("GetRelativePath", GetRelativePath);
		L.RegFunction("New", _CreateGameConst);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("PRO_ENV", get_PRO_ENV, set_PRO_ENV);
		L.RegVar("URL", get_URL, set_URL);
		L.RegVar("HTTP", get_HTTP, set_HTTP);
		L.RegVar("DOWNLOAD_URL", get_DOWNLOAD_URL, set_DOWNLOAD_URL);
		L.RegVar("RESOURCES", get_RESOURCES, set_RESOURCES);
		L.RegVar("RES_LOCAL_ROOT", get_RES_LOCAL_ROOT, set_RES_LOCAL_ROOT);
		L.RegVar("RES_WEB_ROOT", get_RES_WEB_ROOT, set_RES_WEB_ROOT);
		L.RegVar("BUILD_ROOT", get_BUILD_ROOT, set_BUILD_ROOT);
		L.RegVar("BUILD_AB_ROOT", get_BUILD_AB_ROOT, set_BUILD_AB_ROOT);
		L.RegVar("DOWNLOAD_TEMPFILE_ROOT", get_DOWNLOAD_TEMPFILE_ROOT, set_DOWNLOAD_TEMPFILE_ROOT);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateGameConst(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				GameConst obj = new GameConst();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: GameConst.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRelativePath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string o = GameConst.GetRelativePath(arg0, arg1);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PRO_ENV(IntPtr L)
	{
		try
		{
			ToLua.Push(L, GameConst.PRO_ENV);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_URL(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, GameConst.URL);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_HTTP(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, GameConst.HTTP);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DOWNLOAD_URL(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, GameConst.DOWNLOAD_URL);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_RESOURCES(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, GameConst.RESOURCES);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_RES_LOCAL_ROOT(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, GameConst.RES_LOCAL_ROOT);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_RES_WEB_ROOT(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, GameConst.RES_WEB_ROOT);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BUILD_ROOT(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, GameConst.BUILD_ROOT);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BUILD_AB_ROOT(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, GameConst.BUILD_AB_ROOT);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DOWNLOAD_TEMPFILE_ROOT(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, GameConst.DOWNLOAD_TEMPFILE_ROOT);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_PRO_ENV(IntPtr L)
	{
		try
		{
			ENV_TYPE arg0 = (ENV_TYPE)ToLua.CheckObject(L, 2, typeof(ENV_TYPE));
			GameConst.PRO_ENV = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_URL(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			GameConst.URL = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_HTTP(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			GameConst.HTTP = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_DOWNLOAD_URL(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			GameConst.DOWNLOAD_URL = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_RESOURCES(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			GameConst.RESOURCES = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_RES_LOCAL_ROOT(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			GameConst.RES_LOCAL_ROOT = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_RES_WEB_ROOT(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			GameConst.RES_WEB_ROOT = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_BUILD_ROOT(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			GameConst.BUILD_ROOT = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_BUILD_AB_ROOT(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			GameConst.BUILD_AB_ROOT = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_DOWNLOAD_TEMPFILE_ROOT(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			GameConst.DOWNLOAD_TEMPFILE_ROOT = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

