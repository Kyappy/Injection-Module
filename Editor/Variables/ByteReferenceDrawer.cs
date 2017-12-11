using InjectionModule.Variables.Supports;
using Modules.InjectionModule.Contracts;
using UnityEditor;

namespace Modules.InjectionModule.Variables {
	/// <summary>
	/// Byte reference property drawer.
	/// </summary>
	[CustomPropertyDrawer(typeof(ByteReference))]
	public class ByteReferenceDrawer : ReferenceDrawerBase {}
}