using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// Vector2 reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(Vector2Reference))]
	public class Vector2ReferenceDrawer : ReferenceDrawerBase {}
}