using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// Bool reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(BoolReference))]
	public class BoolReferenceDrawer : ReferenceDrawerBase {}
}