using System;
using CSharpLibrary;
using Xunit;

namespace CSharpTests {
	public class DoubleStackTests {
		internal DoubleStack stack = new DoubleStack();

		[Theory]
		[InlineData(5.0, 3.0, 8.0)]
		[InlineData(2.2, 3.3, 5.5)]
		public void Add(Double a, Double b, Double r) {
			stack.Push(a);
			stack.Push(b);
			stack.Add();
			Assert.Equal(r, stack.Pop());
		}

		[Theory]
		[InlineData(5.0, 3.0, 2.0)]
		[InlineData(6.3, 3.3, 3.0)]
		public void Subtract(Double a, Double b, Double r) {
			stack.Push(a);
			stack.Push(b);
			stack.Subtract();
			Assert.Equal(r, stack.Pop());
		}

		[Theory]
		[InlineData(3.0, 2.0, 6.0)]
		[InlineData(1.5, 3.0, 4.5)]
		public void Multiply(Double a, Double b, Double r) {
			stack.Push(a);
			stack.Push(b);
			stack.Multiply();
			Assert.Equal(r, stack.Pop());
		}

		[Theory]
		[InlineData(4.0, 2.0, 2.0)]
		[InlineData(3.0, 3.0, 1.0)]
		public void Divide(Double a, Double b, Double r) {
			stack.Push(a);
			stack.Push(b);
			stack.Divide();
			Assert.Equal(r, stack.Pop());
		}
	}
}
