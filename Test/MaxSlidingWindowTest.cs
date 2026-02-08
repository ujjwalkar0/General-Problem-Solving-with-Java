using Problem_Solving;

namespace Test
{
    public class MaxSlidingWindowTest
    {
        private readonly Solution _solution = new Solution();

        [Fact]
        public void MaxSlidingWindow_Example1_ReturnsCorrectMaxValues()
        {
            // Arrange
            int[] nums = [1, 3, -1, -3, 0, 5, 3, 6, 7];
            int k = 3;

            // Act
            int[] result = _solution.MaxSlidingWindow(nums, k);

            // Assert
            Assert.Equal([3, 3, 5, 5, 6, 7], result);
        }

        [Fact]
        public void MaxSlidingWindow_Example2_SingleElement_ReturnsSameElement()
        {
            // Arrange
            int[] nums = [1];
            int k = 1;

            // Act
            int[] result = _solution.MaxSlidingWindow(nums, k);

            // Assert
            Assert.Equal([1], result);
        }

        [Fact]
        public void MaxSlidingWindow_WindowSizeEqualsArrayLength_ReturnsSingleMax()
        {
            // Arrange
            int[] nums = [1, 3, -1, -3, 5];
            int k = 5;

            // Act
            int[] result = _solution.MaxSlidingWindow(nums, k);

            // Assert
            Assert.Equal([5], result);
        }

        [Fact]
        public void MaxSlidingWindow_AllSameElements_ReturnsAllSameValues()
        {
            // Arrange
            int[] nums = [5, 5, 5, 5, 5];
            int k = 3;

            // Act
            int[] result = _solution.MaxSlidingWindow(nums, k);

            // Assert
            Assert.Equal([5, 5, 5], result);
        }

        [Fact]
        public void MaxSlidingWindow_DecreasingSequence_ReturnsFirstElementsOfEachWindow()
        {
            // Arrange
            int[] nums = [9, 8, 7, 6, 5, 4, 3];
            int k = 3;

            // Act
            int[] result = _solution.MaxSlidingWindow(nums, k);

            // Assert
            Assert.Equal([9, 8, 7, 6, 5], result);
        }

        [Fact]
        public void MaxSlidingWindow_IncreasingSequence_ReturnsLastElementsOfEachWindow()
        {
            // Arrange
            int[] nums = [1, 2, 3, 4, 5, 6, 7];
            int k = 3;

            // Act
            int[] result = _solution.MaxSlidingWindow(nums, k);

            // Assert
            Assert.Equal([3, 4, 5, 6, 7], result);
        }

        [Fact]
        public void MaxSlidingWindow_WithNegativeNumbers_ReturnsCorrectMax()
        {
            // Arrange
            int[] nums = [-7, -8, 7, 5, 7, 1, 6, 0];
            int k = 4;

            // Act
            int[] result = _solution.MaxSlidingWindow(nums, k);

            // Assert
            Assert.Equal([7, 7, 7, 7, 7], result);
        }

        [Fact]
        public void MaxSlidingWindow_AllNegativeNumbers_ReturnsCorrectMax()
        {
            // Arrange
            int[] nums = [-5, -3, -1, -4, -2];
            int k = 2;

            // Act
            int[] result = _solution.MaxSlidingWindow(nums, k);

            // Assert
            Assert.Equal([-3, -1, -1, -2], result);
        }

        [Fact]
        public void MaxSlidingWindow_WindowSizeOne_ReturnsOriginalArray()
        {
            // Arrange
            int[] nums = [1, 3, -1, -3, 5];
            int k = 1;

            // Act
            int[] result = _solution.MaxSlidingWindow(nums, k);

            // Assert
            Assert.Equal([1, 3, -1, -3, 5], result);
        }

        [Fact]
        public void MaxSlidingWindow_TwoElements_WindowSizeTwo_ReturnsSingleMax()
        {
            // Arrange
            int[] nums = [1, -1];
            int k = 2;

            // Act
            int[] result = _solution.MaxSlidingWindow(nums, k);

            // Assert
            Assert.Equal([1], result);
        }

        [Fact]
        public void MaxSlidingWindow_MinAndMaxConstraintValues_HandlesCorrectly()
        {
            // Arrange - using constraint boundary values (-10^4 to 10^4)
            int[] nums = [-10000, 10000, -10000, 10000];
            int k = 2;

            // Act
            int[] result = _solution.MaxSlidingWindow(nums, k);

            // Assert
            Assert.Equal([10000, 10000, 10000], result);
        }

        [Fact]
        public void MaxSlidingWindow_DuplicateMaxValues_ReturnsCorrectMax()
        {
            // Arrange
            int[] nums = [1, 3, 3, 2, 3, 1];
            int k = 3;

            // Act
            int[] result = _solution.MaxSlidingWindow(nums, k);

            // Assert
            Assert.Equal([3, 3, 3, 3], result);
        }
    }
}
