﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ResUtilWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ResUtil), typeof(System.Object));
		L.RegFunction("GetBundleByName", GetBundleByName);
		L.RegFunction("GetBundleByRes", GetBundleByRes);
		L.RegFunction("GetBundlesByRes", GetBundlesByRes);
		L.RegFunction("GetResObjectByRes", GetResObjectByRes);
		L.RegFunction("GetResObjectByResName", GetResObjectByResName);
		L.RegFunction("GetResObjectsByRes", GetResObjectsByRes);
		L.RegFunction("GetRelyABs", GetRelyABs);
		L.RegFunction("ExistAssetBundle", ExistAssetBundle);
		L.RegFunction("DecryptAssetBundle", DecryptAssetBundle);
		L.RegFunction("DecryptAssetBundleAsyn", DecryptAssetBundleAsyn);
		L.RegFunction("LoadAssetBundle", LoadAssetBundle);
		L.RegFunction("LoadAssetBundleAsyn", LoadAssetBundleAsyn);
		L.RegFunction("UnLoadAssetBundle", UnLoadAssetBundle);
		L.RegFunction("Load", Load);
		L.RegFunction("LoadAsyn", LoadAsyn);
		L.RegFunction("UnLoad", UnLoad);
		L.RegFunction("LoadString", LoadString);
		L.RegFunction("LoadStringAsyn", LoadStringAsyn);
		L.RegFunction("LoadBytes", LoadBytes);
		L.RegFunction("LoadBytesAsyn", LoadBytesAsyn);
		L.RegFunction("LoadSprite", LoadSprite);
		L.RegFunction("LoadSpriteAsyn", LoadSpriteAsyn);
		L.RegFunction("LoadGameObject", LoadGameObject);
		L.RegFunction("LoadGameObjectAsyn", LoadGameObjectAsyn);
		L.RegFunction("LoadAnimator", LoadAnimator);
		L.RegFunction("LoadAnimatorAsyn", LoadAnimatorAsyn);
		L.RegFunction("New", _CreateResUtil);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateResUtil(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				ResUtil obj = new ResUtil();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: ResUtil.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBundleByName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.AssetBundle o = obj.GetBundleByName(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBundleByRes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 2);
			UnityEngine.AssetBundle o = obj.GetBundleByRes(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBundlesByRes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 2);
			UnityEngine.AssetBundle[] o = obj.GetBundlesByRes(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetResObjectByRes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 2);
			ResObject o = obj.GetResObjectByRes(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetResObjectByResName(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				ResObject o = obj.GetResObjectByResName(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				UnityEngine.AssetBundle arg0 = (UnityEngine.AssetBundle)ToLua.CheckObject<UnityEngine.AssetBundle>(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				ResObject o = obj.GetResObjectByResName(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResUtil.GetResObjectByResName");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetResObjectsByRes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 2);
			ResObject[] o = obj.GetResObjectsByRes(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRelyABs(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			string[] o = obj.GetRelyABs(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ExistAssetBundle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.ExistAssetBundle(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DecryptAssetBundle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			byte[] o = obj.DecryptAssetBundle(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DecryptAssetBundleAsyn(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			System.Action<byte[]> arg1 = (System.Action<byte[]>)ToLua.CheckDelegate<System.Action<byte[]>>(L, 3);
			obj.DecryptAssetBundleAsyn(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAssetBundle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.AssetBundle o = obj.LoadAssetBundle(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAssetBundleAsyn(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				obj.LoadAssetBundleAsyn(arg0);
				return 0;
			}
			else if (count == 3)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				System.Action<UnityEngine.AssetBundle> arg1 = (System.Action<UnityEngine.AssetBundle>)ToLua.CheckDelegate<System.Action<UnityEngine.AssetBundle>>(L, 3);
				obj.LoadAssetBundleAsyn(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResUtil.LoadAssetBundleAsyn");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnLoadAssetBundle(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				obj.UnLoadAssetBundle(arg0);
				return 0;
			}
			else if (count == 3)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				obj.UnLoadAssetBundle(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResUtil.UnLoadAssetBundle");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Load(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				UnityEngine.Object o = obj.Load(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes<string, string, bool>(L, 2))
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				bool arg2 = LuaDLL.lua_toboolean(L, 4);
				UnityEngine.Object o = obj.Load(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes<System.Type, string, string>(L, 2))
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				string arg2 = ToLua.ToString(L, 4);
				UnityEngine.Object o = obj.Load(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 5)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				System.Type arg0 = ToLua.CheckMonoType(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				string arg2 = ToLua.CheckString(L, 4);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 5);
				UnityEngine.Object o = obj.Load(arg0, arg1, arg2, arg3);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResUtil.Load");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAsyn(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				obj.LoadAsyn(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<System.Type, string, string>(L, 2))
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				string arg2 = ToLua.ToString(L, 4);
				obj.LoadAsyn(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<string, string, System.Action<UnityEngine.Object>>(L, 2))
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				System.Action<UnityEngine.Object> arg2 = (System.Action<UnityEngine.Object>)ToLua.ToObject(L, 4);
				obj.LoadAsyn(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes<string, string, System.Action<UnityEngine.Object>, bool>(L, 2))
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				System.Action<UnityEngine.Object> arg2 = (System.Action<UnityEngine.Object>)ToLua.ToObject(L, 4);
				bool arg3 = LuaDLL.lua_toboolean(L, 5);
				obj.LoadAsyn(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes<System.Type, string, string, System.Action<UnityEngine.Object>>(L, 2))
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				string arg2 = ToLua.ToString(L, 4);
				System.Action<UnityEngine.Object> arg3 = (System.Action<UnityEngine.Object>)ToLua.ToObject(L, 5);
				obj.LoadAsyn(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 6)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				System.Type arg0 = ToLua.CheckMonoType(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				string arg2 = ToLua.CheckString(L, 4);
				System.Action<UnityEngine.Object> arg3 = (System.Action<UnityEngine.Object>)ToLua.CheckDelegate<System.Action<UnityEngine.Object>>(L, 5);
				bool arg4 = LuaDLL.luaL_checkboolean(L, 6);
				obj.LoadAsyn(arg0, arg1, arg2, arg3, arg4);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResUtil.LoadAsyn");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnLoad(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 2);
			obj.UnLoad(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadString(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				string o = obj.LoadString(arg0, arg1);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else if (count == 4)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				string o = obj.LoadString(arg0, arg1, arg2);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResUtil.LoadString");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadStringAsyn(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				obj.LoadStringAsyn(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				System.Action<string> arg2 = (System.Action<string>)ToLua.CheckDelegate<System.Action<string>>(L, 4);
				obj.LoadStringAsyn(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				System.Action<string> arg2 = (System.Action<string>)ToLua.CheckDelegate<System.Action<string>>(L, 4);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 5);
				obj.LoadStringAsyn(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResUtil.LoadStringAsyn");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadBytes(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				byte[] o = obj.LoadBytes(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				byte[] o = obj.LoadBytes(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResUtil.LoadBytes");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadBytesAsyn(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				obj.LoadBytesAsyn(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				System.Action<byte[]> arg2 = (System.Action<byte[]>)ToLua.CheckDelegate<System.Action<byte[]>>(L, 4);
				obj.LoadBytesAsyn(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				System.Action<byte[]> arg2 = (System.Action<byte[]>)ToLua.CheckDelegate<System.Action<byte[]>>(L, 4);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 5);
				obj.LoadBytesAsyn(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResUtil.LoadBytesAsyn");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadSprite(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				UnityEngine.Sprite o = obj.LoadSprite(arg0, arg1);
				ToLua.PushSealed(L, o);
				return 1;
			}
			else if (count == 4)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				UnityEngine.Sprite o = obj.LoadSprite(arg0, arg1, arg2);
				ToLua.PushSealed(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResUtil.LoadSprite");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadSpriteAsyn(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				obj.LoadSpriteAsyn(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				System.Action<UnityEngine.Sprite> arg2 = (System.Action<UnityEngine.Sprite>)ToLua.CheckDelegate<System.Action<UnityEngine.Sprite>>(L, 4);
				obj.LoadSpriteAsyn(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				System.Action<UnityEngine.Sprite> arg2 = (System.Action<UnityEngine.Sprite>)ToLua.CheckDelegate<System.Action<UnityEngine.Sprite>>(L, 4);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 5);
				obj.LoadSpriteAsyn(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResUtil.LoadSpriteAsyn");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadGameObject(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				UnityEngine.GameObject o = obj.LoadGameObject(arg0, arg1);
				ToLua.PushSealed(L, o);
				return 1;
			}
			else if (count == 4)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				UnityEngine.GameObject o = obj.LoadGameObject(arg0, arg1, arg2);
				ToLua.PushSealed(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResUtil.LoadGameObject");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadGameObjectAsyn(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				obj.LoadGameObjectAsyn(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				System.Action<UnityEngine.GameObject> arg2 = (System.Action<UnityEngine.GameObject>)ToLua.CheckDelegate<System.Action<UnityEngine.GameObject>>(L, 4);
				obj.LoadGameObjectAsyn(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				System.Action<UnityEngine.GameObject> arg2 = (System.Action<UnityEngine.GameObject>)ToLua.CheckDelegate<System.Action<UnityEngine.GameObject>>(L, 4);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 5);
				obj.LoadGameObjectAsyn(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResUtil.LoadGameObjectAsyn");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAnimator(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				UnityEngine.RuntimeAnimatorController o = obj.LoadAnimator(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				UnityEngine.RuntimeAnimatorController o = obj.LoadAnimator(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResUtil.LoadAnimator");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAnimatorAsyn(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				obj.LoadAnimatorAsyn(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				System.Action<UnityEngine.RuntimeAnimatorController> arg2 = (System.Action<UnityEngine.RuntimeAnimatorController>)ToLua.CheckDelegate<System.Action<UnityEngine.RuntimeAnimatorController>>(L, 4);
				obj.LoadAnimatorAsyn(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5)
			{
				ResUtil obj = (ResUtil)ToLua.CheckObject<ResUtil>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				string arg1 = ToLua.CheckString(L, 3);
				System.Action<UnityEngine.RuntimeAnimatorController> arg2 = (System.Action<UnityEngine.RuntimeAnimatorController>)ToLua.CheckDelegate<System.Action<UnityEngine.RuntimeAnimatorController>>(L, 4);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 5);
				obj.LoadAnimatorAsyn(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResUtil.LoadAnimatorAsyn");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

