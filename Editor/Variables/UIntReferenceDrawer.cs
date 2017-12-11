using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// UInt reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(UIntReference))]
	public class UIntReferenceDrawer : ReferenceDrawerBase {}
}