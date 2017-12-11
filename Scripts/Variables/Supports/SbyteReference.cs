using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// SByte reference support.
	/// </summary>
	[Serializable]
	public class SByteReference : ReferenceBase<sbyte, SByteVariable> {}
}