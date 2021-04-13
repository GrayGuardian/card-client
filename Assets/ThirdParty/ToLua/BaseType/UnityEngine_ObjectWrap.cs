﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_ObjectWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Object), typeof(System.Object));
		L.RegFunction("GetInstanceID", GetInstanceID);
		L.RegFunction("GetHashCode", GetHashCode);
		L.RegFunction("Equals", Equals);
		L.RegFunction("FindObjectsOfType", FindObjectsOfType);
		L.RegFunction("DontDestroyOnLoad", DontDestroyOnLoad);
		L.RegFunction("FindObjectOfType", FindObjectOfType);
		L.RegFunction("ToString", ToString);
		L.RegFunction("Instantiate", Instantiate);
		L.RegFunction("DestroyImmediate", DestroyImmediate);
		L.RegFunction("Destroy", Destroy);
		L.RegFunction("New", _CreateUnityEngine_Object);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("name", get_name, set_name);
		L.RegVar("hideFlags", get_hideFlags, set_hideFlags);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Object(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Object obj = new UnityEngine.Object();
				ToLua.Push(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Object.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInstanceID(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Object obj = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
			int o = obj.GetInstanceID();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHashCode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Object obj = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
			int o = obj.GetHashCode();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Equals(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object obj = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
			object arg0 = ToLua.ToVarObject(L, 2);
			bool o = obj != null ? obj.Equals(arg0) : arg0 == null;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindObjectsOfType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 1);
			UnityEngine.Object[] o = UnityEngine.Object.FindObjectsOfType(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DontDestroyOnLoad(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
			UnityEngine.Object.DontDestroyOnLoad(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindObjectOfType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 1);
			UnityEngine.Object o = UnityEngine.Object.FindObjectOfType(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Object obj = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
			string o = obj.ToString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Instantiate(IntPtr L)
	{
		IntPtr L0 = LuaException.L;

        try
        {
            ++LuaException.InstantiateCount;            
            LuaException.L = L;
            int count = LuaDLL.lua_gettop(L);

            if (count == 1)
            {
                UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
                UnityEngine.Object o = UnityEngine.Object.Instantiate(arg0);

                if (LuaDLL.lua_toboolean(L, LuaDLL.lua_upvalueindex(1)))
                {
                    string error = LuaDLL.lua_tostring(L, -1);
                    LuaDLL.lua_pop(L, 1);
                    throw new LuaException(error, LuaException.GetLastError());
                }
                else
                {
                    ToLua.Push(L, o);
                }

                LuaException.L = L0;
                --LuaException.InstantiateCount;
                return 1;
            }
#if UNITY_5_4_OR_NEWER
            else if (count == 2)
            {
                UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
                UnityEngine.Transform arg1 = (UnityEngine.Transform)ToLua.CheckObject<UnityEngine.Transform>(L, 2);
                UnityEngine.Object o = UnityEngine.Object.Instantiate(arg0, arg1);

                if (LuaDLL.lua_toboolean(L, LuaDLL.lua_upvalueindex(1)))
                {
                    string error = LuaDLL.lua_tostring(L, -1);
                    LuaDLL.lua_pop(L, 1);
                    throw new LuaException(error, LuaException.GetLastError());
                }
                else
                {
                    ToLua.Push(L, o);
                }

                LuaException.L = L0;
                --LuaException.InstantiateCount;
                return 1;
            }
#endif
            else if (count == 3 && TypeChecker.CheckTypes<UnityEngine.Vector3, UnityEngine.Quaternion>(L, 2))
            {
                UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
                UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 2);
                UnityEngine.Quaternion arg2 = ToLua.ToQuaternion(L, 3);
                UnityEngine.Object o = UnityEngine.Object.Instantiate(arg0, arg1, arg2);

                if (LuaDLL.lua_toboolean(L, LuaDLL.lua_upvalueindex(1)))
                {
                    string error = LuaDLL.lua_tostring(L, -1);
                    LuaDLL.lua_pop(L, 1);
                    throw new LuaException(error, LuaException.GetLastError());
                }
                else
                {
                    ToLua.Push(L, o);
                }

                LuaException.L = L0;
                --LuaException.InstantiateCount;
                return 1;
            }
#if UNITY_5_4_OR_NEWER
            else if (count == 3 && TypeChecker.CheckTypes<UnityEngine.Transform, bool>(L, 2))
            {
                UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
                UnityEngine.Transform arg1 = (UnityEngine.Transform)ToLua.ToObject(L, 2);
                bool arg2 = LuaDLL.lua_toboolean(L, 3);
                UnityEngine.Object o = UnityEngine.Object.Instantiate(arg0, arg1, arg2);

                if (LuaDLL.lua_toboolean(L, LuaDLL.lua_upvalueindex(1)))
                {
                    string error = LuaDLL.lua_tostring(L, -1);
                    LuaDLL.lua_pop(L, 1);
                    throw new LuaException(error, LuaException.GetLastError());
                }
                else
                {
                    ToLua.Push(L, o);
                }

                LuaException.L = L0;
                --LuaException.InstantiateCount;
                return 1;
            }
            else if (count == 4)
            {
                UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
                UnityEngine.Vector3 arg1 = ToLua.CheckVector3(L, 2);
                UnityEngine.Quaternion arg2 = ToLua.CheckQuaternion(L, 3);
                UnityEngine.Transform arg3 = (UnityEngine.Transform)ToLua.CheckObject<UnityEngine.Transform>(L, 4);
                UnityEngine.Object o = UnityEngine.Object.Instantiate(arg0, arg1, arg2, arg3);

                if (LuaDLL.lua_toboolean(L, LuaDLL.lua_upvalueindex(1)))
                {
                    string error = LuaDLL.lua_tostring(L, -1);
                    LuaDLL.lua_pop(L, 1);
                    throw new LuaException(error, LuaException.GetLastError());
                }
                else
                {
                    ToLua.Push(L, o);
                }

                LuaException.L = L0;
                --LuaException.InstantiateCount;
                return 1;
            }
#endif
            else
            {
                LuaException.L = L0;
                --LuaException.InstantiateCount;
                return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Object.Instantiate");
            }
        }
        catch (Exception e)
        {
            LuaException.L = L0;
            --LuaException.InstantiateCount;
            return LuaDLL.toluaL_exception(L, e);
        }
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestroyImmediate(IntPtr L)
	{
        try
        {
            int count = LuaDLL.lua_gettop(L);

            if (count == 1)
            {
                UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
                ToLua.Destroy(L);
                UnityEngine.Object.DestroyImmediate(arg0);
                return 0;
            }
            else if (count == 2)
            {
                UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
                bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
                ToLua.Destroy(L);
                UnityEngine.Object.DestroyImmediate(arg0, arg1);
                return 0;
            }
            else
            {
                return LuaDLL.luaL_throw(L, "invalid arguments to method: Object.DestroyImmediate");
            }
        }
        catch (Exception e)
        {
            return LuaDLL.toluaL_exception(L, e);
        }
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Destroy(IntPtr L)
	{
        try
        {
            int count = LuaDLL.lua_gettop(L);

            if (count == 1)
            {
                UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckObject<UnityEngine.Object>(L, 1);
                ToLua.Destroy(L);
                UnityEngine.Object.Destroy(arg0);
                return 0;
            }
            else if (count == 2)
            {                
                float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
                int udata = LuaDLL.tolua_rawnetobj(L, 1);
                ObjectTranslator translator = LuaState.GetTranslator(L);
                translator.DelayDestroy(udata, arg1);
                return 0;
            }
            else
            {
                return LuaDLL.luaL_throw(L, "invalid arguments to method: Object.Destroy");
            }
        }
        catch (Exception e)
        {
            return LuaDLL.toluaL_exception(L, e);
        }
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Object obj = (UnityEngine.Object)o;
			string ret = obj.name;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hideFlags(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Object obj = (UnityEngine.Object)o;
			UnityEngine.HideFlags ret = obj.hideFlags;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index hideFlags on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Object obj = (UnityEngine.Object)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.name = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hideFlags(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Object obj = (UnityEngine.Object)o;
			UnityEngine.HideFlags arg0 = (UnityEngine.HideFlags)ToLua.CheckObject(L, 2, typeof(UnityEngine.HideFlags));
			obj.hideFlags = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index hideFlags on a nil value");
		}
	}
}

