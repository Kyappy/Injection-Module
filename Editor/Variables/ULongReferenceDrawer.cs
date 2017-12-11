using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// ULong reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(ULongReference))]
	public class ULongReferenceDrawer : ReferenceDrawerBase {}
}