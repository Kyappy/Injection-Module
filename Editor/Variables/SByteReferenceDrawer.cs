using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// SByte reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(SByteReference))]
	public class SByteReferenceDrawer : ReferenceDrawerBase {}
}