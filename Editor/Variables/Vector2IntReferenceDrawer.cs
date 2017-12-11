using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// Vector2Int reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(Vector2IntReference))]
	public class Vector2IntReferenceDrawer : ReferenceDrawerBase {}
}