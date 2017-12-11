using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// Short reference support.
	/// </summary>
	[Serializable]
	public class ShortReference : ReferenceBase<short, ShortVariable> {}
}