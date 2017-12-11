using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// Vector4 reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(Vector4Reference))]
	public class Vector4ReferenceDrawer : ReferenceDrawerBase {}
}