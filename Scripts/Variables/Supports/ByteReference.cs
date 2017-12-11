using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// Byte reference support.
	/// </summary>
	[Serializable]
	public class ByteReference : ReferenceBase<byte, ByteVariable> {}
}