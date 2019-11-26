using System;
using System.Collections.Generic;

namespace CSharpLibrary {
	/// <summary>
	/// Provides a specialized <see cref="Stack{T}"/> of <see cref="Double"/>, for numerical calculations.
	/// </summary>
	public sealed class DoubleStack : Stack<Double> {
		/// <summary>
		/// Adds the two top values on the stack, and pushes the result back on the stack.
		/// </summary>
		public void Add() {
			Double value = Pop();
			Push(Pop() + value);
		}

		/// <summary>
		/// Subtracts the two top values on the stack, and pushes the result back on the stack.
		/// </summary>
		public void Subtract() {
			Double value = Pop();
			Push(Pop() - value);
		}

		/// <summary>
		/// Multiplies the two top values on the stack, and pushes the result back onto the stack.
		/// </summary>
		public void Multiply() {
			Double value = Pop();
			Push(Pop() * value);
		}

		/// <summary>
		/// Divides the two top values on the stack, and pushes the result back onto the stack.
		/// </summary>
		public void Divide() {
			Double value = Pop();
			Push(Pop() / value);
		}
	}
}
