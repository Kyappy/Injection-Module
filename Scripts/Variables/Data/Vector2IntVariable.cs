using InjectionModule.Variables.Contracts;
using UnityEngine;

namespace InjectionModule.Variables.Data {
	/// <summary>
	/// Scriptable vector2Int variable.
	/// </summary>
	/// <seealso cref="ScriptableObject"/>
	[CreateAssetMenu(menuName = "Injection/Variables/Vector2 integer variable", fileName = "Vector2IntVariable")]
	public class Vector2IntVariable : VariableBase<Vector2Int> {}
}