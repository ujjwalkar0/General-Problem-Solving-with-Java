using Problem_Solving;

namespace Test;

public class HappyNumberTest
{
    private readonly Solution _solution = new Solution();

    [Fact]
    public void IsHappy_Example1_19_ReturnsTrue()
    {
        // Arrange
        int n = 19;

        // Act
        bool result = _solution.IsHappy(n);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsHappy_Example2_2_ReturnsFalse()
    {
        // Arrange
        int n = 2;

        // Act
        bool result = _solution.IsHappy(n);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsHappy_1_ReturnsTrue()
    {
        // Arrange
        int n = 1;

        // Act
        bool result = _solution.IsHappy(n);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsHappy_7_ReturnsTrue()
    {
        // Arrange
        int n = 7;

        // Act
        bool result = _solution.IsHappy(n);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsHappy_10_ReturnsTrue()
    {
        // Arrange
        int n = 10;

        // Act
        bool result = _solution.IsHappy(n);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsHappy_100_ReturnsTrue()
    {
        // Arrange
        int n = 100;

        // Act
        bool result = _solution.IsHappy(n);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsHappy_4_ReturnsFalse()
    {
        // Arrange
        int n = 4;

        // Act
        bool result = _solution.IsHappy(n);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsHappy_116_ReturnsFalse()
    {
        // Arrange
        int n = 116;

        // Act
        bool result = _solution.IsHappy(n);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsHappy_LargeHappyNumber_1111111_ReturnsTrue()
    {
        // Arrange
        int n = 1111111;

        // Act
        bool result = _solution.IsHappy(n);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsHappy_MaxConstraintBoundary_ReturnsFalse()
    {
        // Arrange
        int n = int.MaxValue; // 2^31 - 1

        // Act
        bool result = _solution.IsHappy(n);

        // Assert
        Assert.False(result);
    }
}
