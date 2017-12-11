using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// Int reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(IntReference))]
	public class IntReferenceDrawer : ReferenceDrawerBase {}
}