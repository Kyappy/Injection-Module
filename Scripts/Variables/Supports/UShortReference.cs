using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// UShort reference support.
	/// </summary>
	[Serializable]
	public class UShortReference : ReferenceBase<ushort, UShortVariable> {}
}