using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// Vector3 reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(Vector3Reference))]
	public class Vector3ReferenceDrawer : ReferenceDrawerBase {}
}