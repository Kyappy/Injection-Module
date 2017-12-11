using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// String reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(StringReference))]
	public class StringReferenceDrawer : ReferenceDrawerBase {}
}