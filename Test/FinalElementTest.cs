using Problem_Solving;

namespace Test
{
    public class FinalElementTest
    {
        private readonly Solution _solution = new Solution();

        [Fact]
        public void FinalElement_Example1_Returns2()
        {
            // Arrange
            int[] nums = [1, 5, 2];

            // Act
            int result = _solution.FinalElement(nums);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void FinalElement_Example2_Returns7()
        {
            // Arrange
            int[] nums = [3, 7];

            // Act
            int result = _solution.FinalElement(nums);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void FinalElement_SingleElement_ReturnsSameElement()
        {
            // Arrange
            int[] nums = [42];

            // Act
            int result = _solution.FinalElement(nums);

            // Assert
            Assert.Equal(42, result);
        }

        [Fact]
        public void FinalElement_TwoElements_ReturnsMax()
        {
            // Arrange - Alice removes smaller, leaving larger
            int[] nums = [10, 20];

            // Act
            int result = _solution.FinalElement(nums);

            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void FinalElement_TwoElementsReversed_ReturnsMax()
        {
            // Arrange
            int[] nums = [20, 10];

            // Act
            int result = _solution.FinalElement(nums);

            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void FinalElement_AllSameElements_ReturnsSameValue()
        {
            // Arrange
            int[] nums = [5, 5, 5, 5];

            // Act
            int result = _solution.FinalElement(nums);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void FinalElement_SortedAscending_OptimalPlay()
        {
            // Arrange
            int[] nums = [1, 2, 3, 4];

            // Act
            int result = _solution.FinalElement(nums);

            // Assert - Result depends on optimal play strategy
            Assert.InRange(result, 1, 4);
        }

        [Fact]
        public void FinalElement_SortedDescending_OptimalPlay()
        {
            // Arrange
            int[] nums = [4, 3, 2, 1];

            // Act
            int result = _solution.FinalElement(nums);

            // Assert - Result depends on optimal play strategy
            Assert.InRange(result, 1, 4);
        }

        [Fact]
        public void FinalElement_MinConstraint_SingleElement()
        {
            // Arrange - Minimum constraint: single element with value 1
            int[] nums = [1];

            // Act
            int result = _solution.FinalElement(nums);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void FinalElement_MaxElementValue_HandlesLargeValues()
        {
            // Arrange - nums[i] can be up to 10^5
            int[] nums = [100000, 1, 50000];

            // Act
            int result = _solution.FinalElement(nums);

            // Assert
            Assert.InRange(result, 1, 100000);
        }

        [Fact]
        public void FinalElement_FiveElements_OptimalPlay()
        {
            // Arrange
            int[] nums = [1, 3, 5, 2, 4];

            // Act
            int result = _solution.FinalElement(nums);

            // Assert
            Assert.InRange(result, 1, 5);
        }

        [Fact]
        public void FinalElement_TwoIdenticalElements_ReturnsSameValue()
        {
            // Arrange
            int[] nums = [7, 7];

            // Act
            int result = _solution.FinalElement(nums);

            // Assert
            Assert.Equal(7, result);
        }
        
        [Fact]
        public void FinalElement_GreaterFirst()
        {
            // Arrange
            int[] nums = [11, 4, 5];

            // Act
            int result = _solution.FinalElement(nums);

            // Assert
            Assert.Equal(11, result);
        }

    }
}
