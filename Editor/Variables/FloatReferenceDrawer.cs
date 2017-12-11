using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// Float reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(FloatReference))]
	public class FloatReferenceDrawer : ReferenceDrawerBase {}
}