// https://leetcode.com/problems/longest-palindromic-substring/description/
using Problem_Solving;

namespace Test
{
    public class LongestPalindrome
    {
        [Fact]
        public void Test1()
        {
            Solution solution = new Solution();
            string inputStr = "a";
            string result = solution.LongestPalindrome(inputStr);
            Assert.True(result=="a");
        }

        [Fact]
        public void Test2()
        {
            Solution solution = new Solution();
            string inputStr = "aa";
            string result = solution.LongestPalindrome(inputStr);
            Assert.True(result == "aa");
        }

        [Fact]
        public void Test3()
        {
            Solution solution = new Solution();
            string inputStr = "ab";
            string result = solution.LongestPalindrome(inputStr);
            Assert.True(result == "a" || result == "b");
        }

        [Fact]
        public void Test4()
        {
            Solution solution = new Solution();
            string inputStr = "abab";
            string result = solution.LongestPalindrome(inputStr);
            Assert.True(result == "aba");
        }

        [Fact]
        public void Test5()
        {
            Solution solution = new Solution();
            string inputStr = "abb";
            string result = solution.LongestPalindrome(inputStr);
            Assert.True(result == "bb");
        }

        [Fact]
        public void Test6()
        {
            Solution solution = new Solution();
            string inputStr = "abaabaa";
            string result = solution.LongestPalindrome(inputStr);
            Assert.True(result == "abaaba");
        }

        [Fact]
        public void Test7()
        {
            Solution solution = new Solution();
            string inputStr = "abba";
            string result = solution.LongestPalindrome(inputStr);
            Assert.True(result == "abba");
        }

        [Fact]
        public void Test8()
        {
            Solution solution = new Solution();
            string inputStr = "aaaa";
            string result = solution.LongestPalindrome(inputStr);
            Assert.True(result == "aaaa");
        }

        [Fact]
        public void Test9()
        {
            Solution solution = new Solution();
            string inputStr = "aaaaa";
            string result = solution.LongestPalindrome(inputStr);
            Assert.True(result == "aaaaa");
        }



    }
}
