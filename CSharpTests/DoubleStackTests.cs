using System;
using CSharpLibrary;
using Xunit;

namespace CSharpTests {
	public class DoubleStackTests {
		internal DoubleStack stack = new DoubleStack();

		[Theory]
		[InlineData(5.0, 3.0, 8.0, 2.0, 10.0)]
		[InlineData(2.2, 3.3, 5.5, 0.5, 6.0)]
		public void Add(Double a, Double b, Double r1, Double c, Double r2) {
			stack.Push(a);
			stack.Push(b);
			stack.Add();
			Assert.Equal(r1, stack.Peek());
			stack.Push(c);
			stack.Add(out Double r);
			Assert.Equal(r2, r);
		}

		[Theory]
		[InlineData(5.0, 3.0, 2.0, 2.0, 0.0)]
		[InlineData(6.3, 3.3, 3.0, 1.5, 1.5)]
		public void Subtract(Double a, Double b, Double r1, Double c, Double r2) {
			stack.Push(a);
			stack.Push(b);
			stack.Subtract();
			Assert.Equal(r1, stack.Peek());
			stack.Push(c);
			stack.Subtract(out Double r);
			Assert.Equal(r2, r);
		}

		[Theory]
		[InlineData(3.0, 2.0, 6.0, 0.5, 3.0)]
		[InlineData(1.5, 3.0, 4.5, 2.0, 9.0)]
		public void Multiply(Double a, Double b, Double r1, Double c, Double r2) {
			stack.Push(a);
			stack.Push(b);
			stack.Multiply();
			Assert.Equal(r1, stack.Peek());
			stack.Push(c);
			stack.Multiply(out Double r);
			Assert.Equal(r2, r);
		}

		[Theory]
		[InlineData(4.0, 2.0, 2.0, 2.0, 1.0)]
		[InlineData(3.0, 3.0, 1.0, 1.0, 1.0)]
		public void Divide(Double a, Double b, Double r1, Double c, Double r2) {
			stack.Push(a);
			stack.Push(b);
			stack.Divide();
			Assert.Equal(r1, stack.Peek());
			stack.Push(c);
			stack.Divide(out Double r);
			Assert.Equal(r2, r);
		}
	}
}
