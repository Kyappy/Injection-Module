﻿using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// Char reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(CharReference))]
	public class CharReferenceDrawer : ReferenceDrawerBase {}
}