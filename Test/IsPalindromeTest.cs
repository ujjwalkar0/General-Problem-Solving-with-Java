using Problem_Solving;

namespace Test
{
    public class IsPalindromeTest
    {
        private readonly Solution _solution = new Solution();

        [Fact]
        public void IsPalindrome_ValidPalindromeWithSpacesAndPunctuation_ReturnsTrue()
        {
            // Arrange
            string s = "A man, a plan, a canal: Panama";

            // Act
            bool result = _solution.IsPalindrome(s);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_NotAPalindrome_ReturnsFalse()
        {
            // Arrange
            string s = "race a car";

            // Act
            bool result = _solution.IsPalindrome(s);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            // Arrange
            string s = " ";

            // Act
            bool result = _solution.IsPalindrome(s);

            // Assert - empty string is palindrome
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_SingleCharacter_ReturnsTrue()
        {
            // Arrange
            string s = "a";

            // Act
            bool result = _solution.IsPalindrome(s);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_TwoSameCharacters_ReturnsTrue()
        {
            // Arrange
            string s = "aa";

            // Act
            bool result = _solution.IsPalindrome(s);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_TwoDifferentCharacters_ReturnsFalse()
        {
            // Arrange
            string s = "ab";

            // Act
            bool result = _solution.IsPalindrome(s);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_MixedCasePalindrome_ReturnsTrue()
        {
            // Arrange
            string s = "Aa";

            // Act
            bool result = _solution.IsPalindrome(s);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_OnlyNumbers_ReturnsTrue()
        {
            // Arrange
            string s = "12321";

            // Act
            bool result = _solution.IsPalindrome(s);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_NumbersNotPalindrome_ReturnsFalse()
        {
            // Arrange
            string s = "12345";

            // Act
            bool result = _solution.IsPalindrome(s);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_AlphanumericMixed_ReturnsTrue()
        {
            // Arrange
            string s = "a1b2b1a";

            // Act
            bool result = _solution.IsPalindrome(s);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_OnlySpecialCharacters_ReturnsTrue()
        {
            // Arrange
            string s = ".,!@#";

            // Act
            bool result = _solution.IsPalindrome(s);

            // Assert - after removing non-alphanumeric, it's empty = palindrome
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_PalindromeWithNumbers_ReturnsTrue()
        {
            // Arrange
            string s = "0P";

            // Act
            bool result = _solution.IsPalindrome(s);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_AbbNotPalindrome_ReturnsFalse()
        {
            // Arrange
            string s = "abb";

            // Act
            bool result = _solution.IsPalindrome(s);

            // Assert
            Assert.False(result);
        }
    }
}
