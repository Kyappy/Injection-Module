namespace InjectionModule.Variables.Contracts {
	/// <summary>
	/// Reference base support.
	/// </summary>
	public abstract class ReferenceBase<TType, TVariable> where TVariable : VariableBase<TType> {
		#region Public fields		
		/// <summary>
		/// Use a constant value.
		/// </summary>
		public bool UseConstant = true;

		/// <summary>
		/// The constant value.
		/// </summary>
		public TType ConstantValue;

		/// <summary>
		/// The variable float.
		/// </summary>
		public TVariable Variable;
		#endregion

		#region Public getters		
		/// <summary>
		/// Gets the value.
		/// </summary>
		/// <value>
		/// The constant value if it should be used, else the scriptable variable value.
		/// </value>
		public TType Value { get { return UseConstant ? ConstantValue : Variable.Value; } }
		#endregion
	}
}