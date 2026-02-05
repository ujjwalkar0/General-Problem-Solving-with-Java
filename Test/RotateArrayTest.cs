using Problem_Solving;

namespace Test
{
    public class RotateArrayTest
    {
        private readonly Solution _solution = new Solution();

        [Fact]
        public void Rotate_Example1_RotatesBy3()
        {
            // Arrange
            int[] nums = [1, 2, 3, 4, 5, 6, 7];
            int k = 3;

            // Act
            _solution.Rotate(nums, k);

            // Assert
            Assert.Equal([5, 6, 7, 1, 2, 3, 4], nums);
        }

        [Fact]
        public void Rotate_Example2_RotatesBy2()
        {
            // Arrange
            int[] nums = [-1, -100, 3, 99];
            int k = 2;

            // Act
            _solution.Rotate(nums, k);

            // Assert
            Assert.Equal([3, 99, -1, -100], nums);
        }

        [Fact]
        public void Rotate_SingleElement_NoChange()
        {
            // Arrange
            int[] nums = [1];
            int k = 5;

            // Act
            _solution.Rotate(nums, k);

            // Assert
            Assert.Equal([1], nums);
        }

        [Fact]
        public void Rotate_KEqualsZero_NoChange()
        {
            // Arrange
            int[] nums = [1, 2, 3];
            int k = 0;

            // Act
            _solution.Rotate(nums, k);

            // Assert
            Assert.Equal([1, 2, 3], nums);
        }

        [Fact]
        public void Rotate_KEqualsLength_NoChange()
        {
            // Arrange
            int[] nums = [1, 2, 3, 4];
            int k = 4;

            // Act
            _solution.Rotate(nums, k);

            // Assert
            Assert.Equal([1, 2, 3, 4], nums);
        }

        [Fact]
        public void Rotate_KGreaterThanLength_RotatesCorrectly()
        {
            // Arrange
            int[] nums = [1, 2, 3];
            int k = 5; // k % 3 = 2

            // Act
            _solution.Rotate(nums, k);

            // Assert
            Assert.Equal([2, 3, 1], nums);
        }

        [Fact]
        public void Rotate_TwoElements_RotatesBy1()
        {
            // Arrange
            int[] nums = [1, 2];
            int k = 1;

            // Act
            _solution.Rotate(nums, k);

            // Assert
            Assert.Equal([2, 1], nums);
        }

        [Fact]
        public void Rotate_AllSameElements_NoChange()
        {
            // Arrange
            int[] nums = [5, 5, 5, 5];
            int k = 2;

            // Act
            _solution.Rotate(nums, k);

            // Assert
            Assert.Equal([5, 5, 5, 5], nums);
        }

        [Fact]
        public void Rotate_NegativeNumbers_RotatesCorrectly()
        {
            // Arrange
            int[] nums = [-1, -2, -3, -4, -5];
            int k = 2;

            // Act
            _solution.Rotate(nums, k);

            // Assert
            Assert.Equal([-4, -5, -1, -2, -3], nums);
        }

        [Fact]
        public void Rotate_LargeK_RotatesCorrectly()
        {
            // Arrange
            int[] nums = [1, 2, 3, 4, 5];
            int k = 100002; // k % 5 = 2

            // Act
            _solution.Rotate(nums, k);

            // Assert
            Assert.Equal([4, 5, 1, 2, 3], nums);
        }

        [Fact]
        public void Rotate_KEqualsOne_RotatesByOne()
        {
            // Arrange
            int[] nums = [1, 2, 3, 4, 5, 6];
            int k = 1;

            // Act
            _solution.Rotate(nums, k);

            // Assert
            Assert.Equal([6, 1, 2, 3, 4, 5], nums);
        }
    }
}
