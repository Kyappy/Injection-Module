using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// Vector3Int reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(Vector3IntReference))]
	public class Vector3IntReferenceDrawer : ReferenceDrawerBase {}
}