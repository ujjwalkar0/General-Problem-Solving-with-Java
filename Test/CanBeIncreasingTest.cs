using Problem_Solving;

namespace Test
{
    public class CanBeIncreasingTest
    {
        [Fact]
        public void Test1()
        {
            Solution solution = new Solution();
            int[] inputArray = { 1, 5, 3, 4 };
            bool result = solution.CanBeIncreasing(inputArray);
            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            Solution solution = new Solution();
            int[] inputArray = { 1, 3, 1, 4 };
            bool result = solution.CanBeIncreasing(inputArray);
            Assert.False(result);
        }
        [Fact]
        public void Test3()
        {
            Solution solution = new Solution();
            int[] inputArray = { 1, 2, 3, 4 };
            bool result = solution.CanBeIncreasing(inputArray);
            Assert.True(result);
        }

        [Fact]
        public void Test4()
        {
            Solution solution = new Solution();
            int[] inputArray = { 1, 5, 3, 3, 4 };
            bool result = solution.CanBeIncreasing(inputArray);
            Assert.False(result);
        }

        [Fact]
        public void Test5()
        {
            Solution solution = new Solution();
            int[] inputArray = { 1, 5, 6, 3, 4 };
            bool result = solution.CanBeIncreasing(inputArray);
            Assert.False(result);
        }


        [Fact]
        public void Test6()
        {
            Solution solution = new Solution();
            int[] inputArray = { 1, 1, 1, 1 };
            bool result = solution.CanBeIncreasing(inputArray);
            Assert.False(result);
        }

        [Fact]
        public void Test7()
        {
            Solution solution = new Solution();
            int[] inputArray = { 1 };
            bool result = solution.CanBeIncreasing(inputArray);
            Assert.True(result);
        }

        [Fact]
        public void Test8()
        {
            Solution solution = new Solution();
            int[] inputArray = { 1, 3, 3, 5, 6 };
            bool result = solution.CanBeIncreasing(inputArray);
            Assert.True(result);
        }

        [Fact]
        public void Test9()
        {
            Solution solution = new Solution();
            int[] inputArray = { 1, 2, 3 };
            bool result = solution.CanBeIncreasing(inputArray);
            Assert.True(result);
        }
    }
}