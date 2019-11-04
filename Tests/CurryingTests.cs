using System;
using Xunit;

namespace Tests {
	public class CurryingTests {
		[Fact]
		public void FirstVersionTests() {
			var func = Curry.From((int x, int y, int z) => x + y * z);
			var curried = func[5];
			int result1 = curried[6, 7];
			Assert.Equal(47, result1);
			int result2 = curried[6][7];
			Assert.Equal(47, result2);
			int result3 = func[5][6][7];
			Assert.Equal(47, result3);
			int result4 = func[5][6, 7];
			Assert.Equal(47, result4);
			int result5 = func[5, 6][7];
			Assert.Equal(47, result5);
			int result6 = func[5, 6, 7];
			Assert.Equal(47, result6);
		}

		[Fact]
		public void FuncExtensionsTests() {
			Func<int, int, int, int> func = (x, y, z) => x + y * z;
			var curried = func.Curry(5);
			var result1 = curried(6, 7);
			Assert.Equal(47, result1);
			int result2 = curried.Curry(6)(7);
			Assert.Equal(47, result2);
			int result3 = func.Curry(5).Curry(6)(7);
			Assert.Equal(47, result3);
			int result4 = func.Curry(5)(6, 7);
			Assert.Equal(47, result4);
			int result5 = func.Curry(5, 6)(7);
			Assert.Equal(47, result5);
			int result6 = func.Curry(5, 6, 7)();
			Assert.Equal(47, result6);
		}

		[Fact]
		public void ActionExtensionsTests() {
			int a = 0;
			int b = 0;
			int c = 0;
			Action<int, int, int> action = (x, y, z) => {
				a += x;
				b += y;
				c += z;
			};
			action(1, 2, 3);
			Assert.Equal(1, a);
			Assert.Equal(2, b);
			Assert.Equal(3, c);
			action.Curry(4)(5, 6);
			Assert.Equal(5, a);
			Assert.Equal(7, b);
			Assert.Equal(9, c);
			action.Curry(-1, -2, -3)();
			Assert.Equal(4, a);
			Assert.Equal(5, b);
			Assert.Equal(6, c);
		}
	}
}
