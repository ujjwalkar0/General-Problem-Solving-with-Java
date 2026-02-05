using Problem_Solving;

namespace Test
{
    public class MajorityElementTest
    {
        private readonly Solution _solution = new Solution();

        [Fact]
        public void MajorityElement_Example1_Returns3()
        {
            // Arrange
            int[] nums = [3, 2, 3];

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void MajorityElement_Example2_Returns2()
        {
            // Arrange
            int[] nums = [2, 2, 1, 1, 1, 2, 2];

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void MajorityElement_SingleElement_ReturnsThatElement()
        {
            // Arrange
            int[] nums = [1];

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void MajorityElement_TwoSameElements_ReturnsThatElement()
        {
            // Arrange
            int[] nums = [5, 5];

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void MajorityElement_AllSameElements_ReturnsThatElement()
        {
            // Arrange
            int[] nums = [7, 7, 7, 7, 7];

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void MajorityElement_NegativeNumbers_ReturnsCorrectMajority()
        {
            // Arrange
            int[] nums = [-1, -1, 2];

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void MajorityElement_LargeValues_ReturnsCorrectMajority()
        {
            // Arrange
            int[] nums = [1000000000, 1000000000, -1000000000];

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.Equal(1000000000, result);
        }

        [Fact]
        public void MajorityElement_MajorityAtStart_ReturnsCorrectMajority()
        {
            // Arrange
            int[] nums = [1, 1, 1, 2, 3];

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void MajorityElement_MajorityAtEnd_ReturnsCorrectMajority()
        {
            // Arrange
            int[] nums = [2, 3, 1, 1, 1];

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void MajorityElement_MajorityScattered_ReturnsCorrectMajority()
        {
            // Arrange
            int[] nums = [1, 2, 1, 3, 1, 4, 1];

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void MajorityElement_Zero_ReturnsZero()
        {
            // Arrange
            int[] nums = [0, 0, 1];

            // Act
            int result = _solution.MajorityElement(nums);

            // Assert
            Assert.Equal(0, result);
        }
    }
}
