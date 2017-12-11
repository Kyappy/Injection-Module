using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;
using UnityEngine;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// Vector2 reference support.
	/// </summary>
	[Serializable]
	public class Vector2Reference : ReferenceBase<Vector2, Vector2Variable> {}
}