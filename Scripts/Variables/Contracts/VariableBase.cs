using UnityEngine;

namespace InjectionModule.Variables.Contracts {
	/// <summary>
	/// Scriptable variable base.
	/// </summary>
	/// <seealso cref="ScriptableObject"/>
	public class VariableBase<T> : ScriptableObject {
		#region Public fields
		/// <summary>
		/// The variable value.
		/// </summary>
		public T Value;
		#endregion
	}
}