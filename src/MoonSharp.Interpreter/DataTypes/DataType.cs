﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoonSharp.Interpreter
{
	public enum DataType
	{
		// standard Lua types
		Nil,
		Boolean,
		Number,
		String,
		Function,
		Table,
		Tuple,
		UserData,
		Thread,

		Symbol,
		ClrFunction,
		TailCallRequest,
	}

	public static class LuaTypeExtensions
	{
		public static string ToLuaTypeString(this DataType type)
		{
			switch (type)
			{
				case DataType.Nil:
					return "nil";
				case DataType.Boolean:
					return "boolean";
				case DataType.Number:
					return "number";
				case DataType.String:
					return "string";
				case DataType.Function:
					return "function";
				case DataType.ClrFunction:
					return "function";
				case DataType.Table:
					return "table";
				case DataType.UserData:
					return "userdata";
				case DataType.Thread:
					return "thread";
				case DataType.Tuple:
				case DataType.TailCallRequest:
				case DataType.Symbol:
				default:
					throw new ScriptRuntimeException(null, "Unexpected LuaType {0}", type);
			}
		}
	}
}