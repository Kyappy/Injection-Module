﻿using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// ULong reference support.
	/// </summary>
	[Serializable]
	public class ULongReference : ReferenceBase<ulong, ULongVariable> {}
}