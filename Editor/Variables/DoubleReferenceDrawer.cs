using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// Double reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(DoubleReference))]
	public class DoubleReferenceDrawer : ReferenceDrawerBase {}
}