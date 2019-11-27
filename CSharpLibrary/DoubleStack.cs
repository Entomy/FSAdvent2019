using System;
using System.Collections.Generic;

[assembly: CLSCompliant(true)]

namespace CSharpLibrary {
	/// <summary>
	/// Provides a specialized <see cref="Stack{T}"/> of <see cref="Double"/>, for numerical calculations.
	/// </summary>
	public sealed class DoubleStack : Stack<Double> {
		//! This code is deliberately and rediculously procedural/imperative. It is not intended to be used as a reference for good design, because this definately is bad design. It's purely for demonstrative purposes. Procedural/Imperative design has its place, and I don't think you could make a good functional and pure stack, but a stack shouldn't be this extremely procedural/imperative.

		/// <summary>
		/// Adds the two top values on the stack, and pushes the result back on the stack.
		/// </summary>
		public void Add() {
			Double value = Pop();
			Push(Pop() + value);
		}

		/// <summary>
		/// Adds the two top values on the stack, and outputs the <paramref name="result"/>.
		/// </summary>
		/// <param name="result"></param>
		public void Add(out Double result) {
			Add();
			result = Pop();
		}

		/// <summary>
		/// Subtracts the two top values on the stack, and pushes the result back on the stack.
		/// </summary>
		public void Subtract() {
			Double value = Pop();
			Push(Pop() - value);
		}

		/// <summary>
		/// Adds the two top values on the stack, and outputs the <paramref name="result"/>.
		/// </summary>
		/// <param name="result"></param>
		public void Subtract(out Double result) {
			Subtract();
			result = Pop();
		}

		/// <summary>
		/// Multiplies the two top values on the stack, and pushes the result back onto the stack.
		/// </summary>
		public void Multiply() {
			Double value = Pop();
			Push(Pop() * value);
		}

		/// <summary>
		/// Multiplies the two top values on the stack, and outputs the <paramref name="result"/>.
		/// </summary>
		/// <param name="result"></param>
		public void Multiply(out Double result) {
			Multiply();
			result = Pop();
		}

		/// <summary>
		/// Divides the two top values on the stack, and pushes the result back onto the stack.
		/// </summary>
		public void Divide() {
			Double value = Pop();
			Push(Pop() / value);
		}

		/// <summary>
		/// Divides the two top values on the stack, and outputs the <paramref name="result"/>.
		/// </summary>
		/// <param name="result"></param>
		public void Divide(out Double result) {
			Divide();
			result = Pop();
		}
	}
}
