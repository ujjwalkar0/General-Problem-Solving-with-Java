using Problem_Solving;

namespace Test
{
    public class ValidParentheses
    {
        [Fact]
        public void Test1()
        {
            Solution solution = new Solution();
            string inputStr = "()";
            bool result = solution.IsValid(inputStr);
            Assert.True(result == true);
        }

        [Fact]
        public void Test2()
        {
            Solution solution = new Solution();
            string inputStr = "()[]{}";
            bool result = solution.IsValid(inputStr);
            Assert.True(result == true);
        }

        [Fact]
        public void Test3()
        {
            Solution solution = new Solution();
            string inputStr = "(]";
            bool result = solution.IsValid(inputStr);
            Assert.True(result == false);
        }

        [Fact]
        public void Test4()
        {
            Solution solution = new Solution();
            string inputStr = "([])";
            bool result = solution.IsValid(inputStr);
            Assert.True(result == true);
        }

        [Fact]
        public void Test5()
        {
            Solution solution = new Solution();
            string inputStr = "([)]";
            bool result = solution.IsValid(inputStr);
            Assert.True(result == false);
        }

        [Fact]
        public void Test6()
        {
            Solution solution = new Solution();
            string inputStr = "]";
            bool result = solution.IsValid(inputStr);
            Assert.True(result == false);
        }

    }
}