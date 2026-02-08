using Problem_Solving;

namespace Test
{
    public class CountMonobitTest
    {
        private readonly Solution _solution = new Solution();

        [Fact]
        public void CountMonobit_Example1_Returns2()
        {
            // Arrange
            int n = 1;

            // Act
            int result = _solution.CountMonobit(n);

            // Assert
            Assert.Equal(2, result); // 0 ("0") and 1 ("1")
        }

        [Fact]
        public void CountMonobit_Example2_Returns3()
        {
            // Arrange
            int n = 4;

            // Act
            int result = _solution.CountMonobit(n);

            // Assert
            Assert.Equal(3, result); // 0, 1, 3
        }

        [Fact]
        public void CountMonobit_Zero_Returns1()
        {
            // Arrange
            int n = 0;

            // Act
            int result = _solution.CountMonobit(n);

            // Assert
            Assert.Equal(1, result); // Only 0
        }

        [Fact]
        public void CountMonobit_Two_Returns2()
        {
            // Arrange
            int n = 2;

            // Act
            int result = _solution.CountMonobit(n);

            // Assert
            Assert.Equal(2, result); // 0, 1 (2 = "10" is not monobit)
        }

        [Fact]
        public void CountMonobit_Three_Returns3()
        {
            // Arrange
            int n = 3;

            // Act
            int result = _solution.CountMonobit(n);

            // Assert
            Assert.Equal(3, result); // 0, 1, 3
        }

        [Fact]
        public void CountMonobit_Seven_Returns4()
        {
            // Arrange
            int n = 7;

            // Act
            int result = _solution.CountMonobit(n);

            // Assert
            Assert.Equal(4, result); // 0, 1, 3, 7
        }

        [Fact]
        public void CountMonobit_Fifteen_Returns5()
        {
            // Arrange
            int n = 15;

            // Act
            int result = _solution.CountMonobit(n);

            // Assert
            Assert.Equal(5, result); // 0, 1, 3, 7, 15
        }

        [Fact]
        public void CountMonobit_BetweenMonobits_Returns5()
        {
            // Arrange
            int n = 20;

            // Act
            int result = _solution.CountMonobit(n);

            // Assert
            Assert.Equal(5, result); // 0, 1, 3, 7, 15 (next monobit is 31)
        }

        [Fact]
        public void CountMonobit_MaxConstraint_Returns10()
        {
            // Arrange
            int n = 1000;

            // Act
            int result = _solution.CountMonobit(n);

            // Assert
            // Monobit numbers up to 1000: 0, 1, 3, 7, 15, 31, 63, 127, 255, 511
            Assert.Equal(10, result);
        }

        [Fact]
        public void CountMonobit_ExactlyOnMonobit_Returns9()
        {
            // Arrange
            int n = 255;

            // Act
            int result = _solution.CountMonobit(n);

            // Assert
            // Monobit numbers: 0, 1, 3, 7, 15, 31, 63, 127, 255
            Assert.Equal(9, result);
        }

        [Fact]
        public void CountMonobit_JustAfterMonobit_Returns9()
        {
            // Arrange
            int n = 256;

            // Act
            int result = _solution.CountMonobit(n);

            // Assert
            // Monobit numbers: 0, 1, 3, 7, 15, 31, 63, 127, 255 (256 = "100000000" is not monobit)
            Assert.Equal(9, result);
        }
    }
}
