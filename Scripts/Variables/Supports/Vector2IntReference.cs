using System;
using InjectionModule.Variables.Contracts;
using InjectionModule.Variables.Data;
using UnityEngine;

namespace InjectionModule.Variables.Supports {
	/// <summary>
	/// Vector2Int reference support.
	/// </summary>
	[Serializable]
	public class Vector2IntReference : ReferenceBase<Vector2Int, Vector2IntVariable> {}
}