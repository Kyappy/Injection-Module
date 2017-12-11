﻿using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// Char reference support.
	/// </summary>
	[Serializable]
	public class CharReference : ReferenceBase<char, CharVariable> {}
}