using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// Short reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(ShortReference))]
	public class ShortReferenceDrawer : ReferenceDrawerBase {}
}