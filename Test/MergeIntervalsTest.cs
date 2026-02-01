using Problem_Solving;

namespace Test
{
    public class MergeIntervalsTest
    {
        private readonly Solution _solution = new Solution();

        // Helper method to compare two 2D arrays
        private bool AreIntervalsEqual(int[][] result, int[][] expected)
        {
            if (result.Length != expected.Length)
                return false;

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Length != expected[i].Length)
                    return false;
                if (result[i][0] != expected[i][0] || result[i][1] != expected[i][1])
                    return false;
            }
            return true;
        }

        [Fact]
        public void Merge_OverlappingIntervals_ReturnsMerged()
        {
            // Arrange
            int[][] intervals = [[1, 3], [2, 6], [8, 10], [15, 18]];

            // Act
            int[][] result = _solution.Merge(intervals);

            // Assert
            int[][] expected = [[1, 6], [8, 10], [15, 18]];
            Assert.True(AreIntervalsEqual(result, expected));
        }

        [Fact]
        public void Merge_TouchingIntervals_ReturnsMerged()
        {
            // Arrange
            int[][] intervals = [[1, 4], [4, 5]];

            // Act
            int[][] result = _solution.Merge(intervals);

            // Assert
            int[][] expected = [[1, 5]];
            Assert.True(AreIntervalsEqual(result, expected));
        }

        [Fact]
        public void Merge_UnsortedTouchingIntervals_ReturnsMerged()
        {
            // Arrange
            int[][] intervals = [[4, 7], [1, 4]];

            // Act
            int[][] result = _solution.Merge(intervals);

            // Assert
            int[][] expected = [[1, 7]];
            Assert.True(AreIntervalsEqual(result, expected));
        }

        [Fact]
        public void Merge_SingleInterval_ReturnsSameInterval()
        {
            // Arrange
            int[][] intervals = [[1, 5]];

            // Act
            int[][] result = _solution.Merge(intervals);

            // Assert
            int[][] expected = [[1, 5]];
            Assert.True(AreIntervalsEqual(result, expected));
        }

        [Fact]
        public void Merge_NoOverlap_ReturnsAllIntervals()
        {
            // Arrange
            int[][] intervals = [[1, 2], [4, 5], [7, 8]];

            // Act
            int[][] result = _solution.Merge(intervals);

            // Assert
            int[][] expected = [[1, 2], [4, 5], [7, 8]];
            Assert.True(AreIntervalsEqual(result, expected));
        }

        [Fact]
        public void Merge_AllOverlapping_ReturnsSingleInterval()
        {
            // Arrange
            int[][] intervals = [[1, 4], [2, 5], [3, 6]];

            // Act
            int[][] result = _solution.Merge(intervals);

            // Assert
            int[][] expected = [[1, 6]];
            Assert.True(AreIntervalsEqual(result, expected));
        }

        [Fact]
        public void Merge_NestedIntervals_ReturnsMerged()
        {
            // Arrange
            int[][] intervals = [[1, 10], [2, 5], [6, 8]];

            // Act
            int[][] result = _solution.Merge(intervals);

            // Assert
            int[][] expected = [[1, 10]];
            Assert.True(AreIntervalsEqual(result, expected));
        }

        [Fact]
        public void Merge_UnsortedIntervals_ReturnsSortedMerged()
        {
            // Arrange
            int[][] intervals = [[8, 10], [1, 3], [2, 6], [15, 18]];

            // Act
            int[][] result = _solution.Merge(intervals);

            // Assert
            int[][] expected = [[1, 6], [8, 10], [15, 18]];
            Assert.True(AreIntervalsEqual(result, expected));
        }

        [Fact]
        public void Merge_SameIntervals_ReturnsSingleInterval()
        {
            // Arrange
            int[][] intervals = [[1, 4], [1, 4]];

            // Act
            int[][] result = _solution.Merge(intervals);

            // Assert
            int[][] expected = [[1, 4]];
            Assert.True(AreIntervalsEqual(result, expected));
        }

        [Fact]
        public void Merge_ZeroLengthIntervals_ReturnsMerged()
        {
            // Arrange
            int[][] intervals = [[1, 1], [2, 2], [3, 3]];

            // Act
            int[][] result = _solution.Merge(intervals);

            // Assert
            int[][] expected = [[1, 1], [2, 2], [3, 3]];
            Assert.True(AreIntervalsEqual(result, expected));
        }

        [Fact]
        public void Merge_ChainedIntervals_ReturnsSingleInterval()
        {
            // Arrange
            int[][] intervals = [[1, 2], [2, 3], [3, 4], [4, 5]];

            // Act
            int[][] result = _solution.Merge(intervals);

            // Assert
            int[][] expected = [[1, 5]];
            Assert.True(AreIntervalsEqual(result, expected));
        }
    }
}
