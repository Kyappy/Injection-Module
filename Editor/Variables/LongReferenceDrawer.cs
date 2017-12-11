using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// Long reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(LongReference))]
	public class LongReferenceDrawer : ReferenceDrawerBase {}
}