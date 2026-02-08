using Problem_Solving;

namespace Test;

public class EvaluateReversePolishNotationTest
{
    private readonly Solution _solution = new Solution();

    // Example test cases from problem description
    [Fact]
    public void EvalRPN_Example1_Returns9()
    {
        // Arrange
        string[] tokens = ["2", "1", "+", "3", "*"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void EvalRPN_Example2_Returns6()
    {
        // Arrange
        string[] tokens = ["4", "13", "5", "/", "+"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void EvalRPN_Example3_Returns22()
    {
        // Arrange
        string[] tokens = ["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(22, result);
    }

    // Edge cases
    [Fact]
    public void EvalRPN_SingleNumber_ReturnsThatNumber()
    {
        // Arrange
        string[] tokens = ["42"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(42, result);
    }

    [Fact]
    public void EvalRPN_SingleNegativeNumber_ReturnsThatNumber()
    {
        // Arrange
        string[] tokens = ["-42"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(-42, result);
    }

    // Basic operations
    [Fact]
    public void EvalRPN_SimpleAddition_ReturnsCorrectSum()
    {
        // Arrange
        string[] tokens = ["3", "4", "+"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void EvalRPN_SimpleSubtraction_ReturnsCorrectDifference()
    {
        // Arrange
        string[] tokens = ["10", "3", "-"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void EvalRPN_SimpleMultiplication_ReturnsCorrectProduct()
    {
        // Arrange
        string[] tokens = ["5", "6", "*"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(30, result);
    }

    [Fact]
    public void EvalRPN_SimpleDivision_ReturnsCorrectQuotient()
    {
        // Arrange
        string[] tokens = ["20", "4", "/"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(5, result);
    }

    // Division truncation toward zero
    [Fact]
    public void EvalRPN_DivisionTruncatesTowardZero_PositiveResult()
    {
        // Arrange
        string[] tokens = ["7", "3", "/"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void EvalRPN_DivisionTruncatesTowardZero_NegativeResult()
    {
        // Arrange
        string[] tokens = ["-7", "3", "/"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(-2, result);
    }

    // Negative numbers
    [Fact]
    public void EvalRPN_NegativeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        string[] tokens = ["-5", "-3", "+"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(-8, result);
    }

    [Fact]
    public void EvalRPN_MixedSignNumbers_ReturnsCorrectResult()
    {
        // Arrange
        string[] tokens = ["-5", "3", "*"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(-15, result);
    }

    // Boundary values from constraints
    [Fact]
    public void EvalRPN_MaxBoundaryValue_ReturnsCorrectResult()
    {
        // Arrange
        string[] tokens = ["200", "200", "+"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(400, result);
    }

    [Fact]
    public void EvalRPN_MinBoundaryValue_ReturnsCorrectResult()
    {
        // Arrange
        string[] tokens = ["-200", "-200", "+"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(-400, result);
    }

    // Complex expressions
    [Fact]
    public void EvalRPN_ComplexExpression_ReturnsCorrectResult()
    {
        // Arrange - ((3 + 4) * 2) - 5 = 9
        string[] tokens = ["3", "4", "+", "2", "*", "5", "-"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void EvalRPN_ZeroResult_ReturnsZero()
    {
        // Arrange
        string[] tokens = ["5", "5", "-"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void EvalRPN_MultiplyByZero_ReturnsZero()
    {
        // Arrange
        string[] tokens = ["100", "0", "*"];
        
        // Act
        int result = _solution.EvalRPN(tokens);
        
        // Assert
        Assert.Equal(0, result);
    }
}
