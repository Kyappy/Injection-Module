using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// String reference support.
	/// </summary>
	[Serializable]
	public class StringReference : ReferenceBase<string, StringVariable> {}
}