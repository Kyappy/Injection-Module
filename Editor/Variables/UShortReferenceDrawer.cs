using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// UShort reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(UShortReference))]
	public class UShortReferenceDrawer : ReferenceDrawerBase {}
}