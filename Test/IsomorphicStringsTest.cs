using Problem_Solving;

namespace Test;

public class IsomorphicStringsTest
{
    private readonly Solution _solution = new Solution();

    // Example 1: "egg" and "add" are isomorphic
    [Fact]
    public void IsIsomorphic_EggAndAdd_ReturnsTrue()
    {
        // Arrange
        string s = "egg";
        string t = "add";

        // Act
        bool result = _solution.IsIsomorphic(s, t);

        // Assert
        Assert.True(result);
    }

    // Example 2: "f11" and "b23" are not isomorphic (1 maps to both 2 and 3)
    [Fact]
    public void IsIsomorphic_F11AndB23_ReturnsFalse()
    {
        // Arrange
        string s = "f11";
        string t = "b23";

        // Act
        bool result = _solution.IsIsomorphic(s, t);

        // Assert
        Assert.False(result);
    }

    // Example 3: "paper" and "title" are isomorphic
    [Fact]
    public void IsIsomorphic_PaperAndTitle_ReturnsTrue()
    {
        // Arrange
        string s = "paper";
        string t = "title";

        // Act
        bool result = _solution.IsIsomorphic(s, t);

        // Assert
        Assert.True(result);
    }

    // Edge case: Single character strings
    [Fact]
    public void IsIsomorphic_SingleCharacter_ReturnsTrue()
    {
        // Arrange
        string s = "a";
        string t = "b";

        // Act
        bool result = _solution.IsIsomorphic(s, t);

        // Assert
        Assert.True(result);
    }

    // Edge case: Same strings (character maps to itself)
    [Fact]
    public void IsIsomorphic_SameStrings_ReturnsTrue()
    {
        // Arrange
        string s = "abc";
        string t = "abc";

        // Act
        bool result = _solution.IsIsomorphic(s, t);

        // Assert
        Assert.True(result);
    }

    // Edge case: Two different characters in s map to same character in t
    [Fact]
    public void IsIsomorphic_TwoCharsMapToOne_ReturnsFalse()
    {
        // Arrange
        string s = "ab";
        string t = "aa";

        // Act
        bool result = _solution.IsIsomorphic(s, t);

        // Assert
        Assert.False(result);
    }

    // Edge case: "foo" and "bar" - 'o' appears twice but maps to different chars
    [Fact]
    public void IsIsomorphic_FooAndBar_ReturnsFalse()
    {
        // Arrange
        string s = "foo";
        string t = "bar";

        // Act
        bool result = _solution.IsIsomorphic(s, t);

        // Assert
        Assert.False(result);
    }

    // Edge case: All same characters
    [Fact]
    public void IsIsomorphic_AllSameCharacters_ReturnsTrue()
    {
        // Arrange
        string s = "aaaa";
        string t = "bbbb";

        // Act
        bool result = _solution.IsIsomorphic(s, t);

        // Assert
        Assert.True(result);
    }

    // Edge case: "badc" and "baba" - reverse mapping conflict
    [Fact]
    public void IsIsomorphic_ReverseMappingConflict_ReturnsFalse()
    {
        // Arrange
        string s = "badc";
        string t = "baba";

        // Act
        bool result = _solution.IsIsomorphic(s, t);

        // Assert
        Assert.False(result);
    }

    // Edge case: Longer isomorphic strings
    [Fact]
    public void IsIsomorphic_LongerIsomorphicStrings_ReturnsTrue()
    {
        // Arrange
        string s = "abcdefghij";
        string t = "klmnopqrst";

        // Act
        bool result = _solution.IsIsomorphic(s, t);

        // Assert
        Assert.True(result);
    }

    // Edge case: Special ASCII characters
    [Fact]
    public void IsIsomorphic_SpecialAsciiCharacters_ReturnsTrue()
    {
        // Arrange
        string s = "!@#";
        string t = "$%^";

        // Act
        bool result = _solution.IsIsomorphic(s, t);

        // Assert
        Assert.True(result);
    }

    // Edge case: Numbers and letters mixed
    [Fact]
    public void IsIsomorphic_NumbersAndLettersMixed_ReturnsTrue()
    {
        // Arrange
        string s = "a1b2";
        string t = "x9y8";

        // Act
        bool result = _solution.IsIsomorphic(s, t);

        // Assert
        Assert.True(result);
    }
}
