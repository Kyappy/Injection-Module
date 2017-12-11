using InjectionModule.Variables.Contracts;
using UnityEngine;

namespace InjectionModule.Variables.Data {
	/// <summary>
	/// Scriptable string variable.
	/// </summary>
	/// <seealso cref="ScriptableObject"/>
	[CreateAssetMenu(menuName = "Injection/Variables/String variable", fileName = "StringVariable")]
	public class StringVariable : VariableBase<string> {}
}