﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class HttpUtilWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(HttpUtil), typeof(System.Object));
		L.RegFunction("Get_Asyn", Get_Asyn);
		L.RegFunction("Get", Get);
		L.RegFunction("Post_Asyn", Post_Asyn);
		L.RegFunction("Post", Post);
		L.RegFunction("Download", Download);
		L.RegFunction("New", _CreateHttpUtil);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateHttpUtil(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				HttpUtil obj = new HttpUtil();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: HttpUtil.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Get_Asyn(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				obj.Get_Asyn(arg0);
				return 0;
			}
			else if (count == 3)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Action<HttpResult> arg1 = (System.Action<HttpResult>)ToLua.CheckDelegate<System.Action<HttpResult>>(L, 3);
				obj.Get_Asyn(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Action<HttpResult> arg1 = (System.Action<HttpResult>)ToLua.CheckDelegate<System.Action<HttpResult>>(L, 3);
				System.Action arg2 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 4);
				obj.Get_Asyn(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: HttpUtil.Get_Asyn");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Get(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				HttpResult o = obj.Get(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Action arg1 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 3);
				HttpResult o = obj.Get(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: HttpUtil.Get");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Post_Asyn(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				byte[] arg1 = ToLua.CheckByteBuffer(L, 3);
				string arg2 = ToLua.CheckString(L, 4);
				obj.Post_Asyn(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				byte[] arg1 = ToLua.CheckByteBuffer(L, 3);
				string arg2 = ToLua.CheckString(L, 4);
				System.Action<HttpResult> arg3 = (System.Action<HttpResult>)ToLua.CheckDelegate<System.Action<HttpResult>>(L, 5);
				obj.Post_Asyn(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 6)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				byte[] arg1 = ToLua.CheckByteBuffer(L, 3);
				string arg2 = ToLua.CheckString(L, 4);
				System.Action<HttpResult> arg3 = (System.Action<HttpResult>)ToLua.CheckDelegate<System.Action<HttpResult>>(L, 5);
				System.Action arg4 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 6);
				obj.Post_Asyn(arg0, arg1, arg2, arg3, arg4);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: HttpUtil.Post_Asyn");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Post(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				byte[] arg1 = ToLua.CheckByteBuffer(L, 3);
				HttpResult o = obj.Post(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 4)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				byte[] arg1 = ToLua.CheckByteBuffer(L, 3);
				string arg2 = ToLua.CheckString(L, 4);
				HttpResult o = obj.Post(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 5)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				byte[] arg1 = ToLua.CheckByteBuffer(L, 3);
				string arg2 = ToLua.CheckString(L, 4);
				System.Action arg3 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 5);
				HttpResult o = obj.Post(arg0, arg1, arg2, arg3);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: HttpUtil.Post");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Download(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				obj.Download(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				string arg2 = ToLua.CheckString(L, 4);
				obj.Download(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				string arg2 = ToLua.CheckString(L, 4);
				System.Action arg3 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 5);
				obj.Download(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 6)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				string arg2 = ToLua.CheckString(L, 4);
				System.Action arg3 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 5);
				System.Action<int,int> arg4 = (System.Action<int,int>)ToLua.CheckDelegate<System.Action<int,int>>(L, 6);
				obj.Download(arg0, arg1, arg2, arg3, arg4);
				return 0;
			}
			else if (count == 7)
			{
				HttpUtil obj = (HttpUtil)ToLua.CheckObject<HttpUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				string arg2 = ToLua.CheckString(L, 4);
				System.Action arg3 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 5);
				System.Action<int,int> arg4 = (System.Action<int,int>)ToLua.CheckDelegate<System.Action<int,int>>(L, 6);
				System.Action arg5 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 7);
				obj.Download(arg0, arg1, arg2, arg3, arg4, arg5);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: HttpUtil.Download");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

