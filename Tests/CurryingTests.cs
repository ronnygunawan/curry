using System;
using Xunit;

namespace Tests {
	public class CurryingTests {
		[Fact]
		public void Test1() {
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
	}
}
