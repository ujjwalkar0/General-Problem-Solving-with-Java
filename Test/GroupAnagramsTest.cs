using Problem_Solving;

namespace Test
{
    public class GroupAnagramsTest
    {
        private readonly Solution _solution = new Solution();

        // Helper method to compare two lists of lists (order-independent)
        private bool AreGroupsEqual(IList<IList<string>> result, IList<IList<string>> expected)
        {
            if (result.Count != expected.Count)
                return false;

            // Sort each inner list and convert to comparable format
            var sortedResult = result
                .Select(g => string.Join(",", g.OrderBy(s => s)))
                .OrderBy(s => s)
                .ToList();

            var sortedExpected = expected
                .Select(g => string.Join(",", g.OrderBy(s => s)))
                .OrderBy(s => s)
                .ToList();

            return sortedResult.SequenceEqual(sortedExpected);
        }

        [Fact]
        public void GroupAnagrams_StandardInput_ReturnsGroupedAnagrams()
        {
            // Arrange
            string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];

            // Act
            IList<IList<string>> result = _solution.GroupAnagrams(strs);

            // Assert
            IList<IList<string>> expected = new List<IList<string>>
            {
                new List<string> { "eat", "tea", "ate" },
                new List<string> { "tan", "nat" },
                new List<string> { "bat" }
            };
            Assert.True(AreGroupsEqual(result, expected));
        }

        [Fact]
        public void GroupAnagrams_EmptyString_ReturnsSingleGroup()
        {
            // Arrange
            string[] strs = [""];

            // Act
            IList<IList<string>> result = _solution.GroupAnagrams(strs);

            // Assert
            IList<IList<string>> expected = new List<IList<string>>
            {
                new List<string> { "" }
            };
            Assert.True(AreGroupsEqual(result, expected));
        }

        [Fact]
        public void GroupAnagrams_SingleElement_ReturnsSingleGroup()
        {
            // Arrange
            string[] strs = ["a"];

            // Act
            IList<IList<string>> result = _solution.GroupAnagrams(strs);

            // Assert
            IList<IList<string>> expected = new List<IList<string>>
            {
                new List<string> { "a" }
            };
            Assert.True(AreGroupsEqual(result, expected));
        }

        [Fact]
        public void GroupAnagrams_NoAnagrams_ReturnsIndividualGroups()
        {
            // Arrange
            string[] strs = ["abc", "def", "ghi"];

            // Act
            IList<IList<string>> result = _solution.GroupAnagrams(strs);

            // Assert
            IList<IList<string>> expected = new List<IList<string>>
            {
                new List<string> { "abc" },
                new List<string> { "def" },
                new List<string> { "ghi" }
            };
            Assert.True(AreGroupsEqual(result, expected));
        }

        [Fact]
        public void GroupAnagrams_AllAnagrams_ReturnsSingleGroup()
        {
            // Arrange
            string[] strs = ["abc", "bca", "cab", "cba"];

            // Act
            IList<IList<string>> result = _solution.GroupAnagrams(strs);

            // Assert
            IList<IList<string>> expected = new List<IList<string>>
            {
                new List<string> { "abc", "bca", "cab", "cba" }
            };
            Assert.True(AreGroupsEqual(result, expected));
        }

        [Fact]
        public void GroupAnagrams_DuplicateStrings_GroupsTogether()
        {
            // Arrange
            string[] strs = ["a", "a", "a"];

            // Act
            IList<IList<string>> result = _solution.GroupAnagrams(strs);

            // Assert
            IList<IList<string>> expected = new List<IList<string>>
            {
                new List<string> { "a", "a", "a" }
            };
            Assert.True(AreGroupsEqual(result, expected));
        }

        [Fact]
        public void GroupAnagrams_MixedLengths_GroupsCorrectly()
        {
            // Arrange
            string[] strs = ["a", "ab", "ba", "abc", "bca"];

            // Act
            IList<IList<string>> result = _solution.GroupAnagrams(strs);

            // Assert
            IList<IList<string>> expected = new List<IList<string>>
            {
                new List<string> { "a" },
                new List<string> { "ab", "ba" },
                new List<string> { "abc", "bca" }
            };
            Assert.True(AreGroupsEqual(result, expected));
        }

        [Fact]
        public void GroupAnagrams_EmptyArray_ReturnsEmptyList()
        {
            // Arrange
            string[] strs = [];

            // Act
            IList<IList<string>> result = _solution.GroupAnagrams(strs);

            // Assert
            Assert.Empty(result);
        }
    }
}
