using InjectionModule.Variables.Contracts;
using UnityEngine;

namespace InjectionModule.Variables.Data {
	/// <summary>
	/// Scriptable vector4 variable.
	/// </summary>
	/// <seealso cref="ScriptableObject"/>
	[CreateAssetMenu(menuName = "Injection/Variables/Vector4 variable", fileName = "Vector4Variable")]
	public class Vector4Variable : VariableBase<Vector4> {}
}