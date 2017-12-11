using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// UInt reference support.
	/// </summary>
	[Serializable]
	public class UIntReference : ReferenceBase<uint, UIntVariable> {}
}