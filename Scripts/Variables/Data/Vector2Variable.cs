using InjectionModule.Variables.Contracts;
using UnityEngine;

namespace InjectionModule.Variables.Data {
	/// <summary>
	/// Scriptable vector2 variable.
	/// </summary>
	/// <seealso cref="ScriptableObject"/>
	[CreateAssetMenu(menuName = "Injection/Variables/Vector2 variable", fileName = "Vector2Variable")]
	public class Vector2Variable : VariableBase<Vector2> {}
}