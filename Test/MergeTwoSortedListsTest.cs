
using Models;
using Problem_Solving;

namespace Test
{
    public class MergeTwoSortedListsTest
    {
        private readonly Solution _solution = new Solution();

        // Helper method to compare two linked lists
        private bool AreListsEqual(ListNode? list1, ListNode? list2)
        {
            while (list1 != null && list2 != null)
            {
                if (list1.val != list2.val)
                    return false;
                list1 = list1.next;
                list2 = list2.next;
            }
            return list1 == null && list2 == null;
        }

        [Fact]
        public void MergeTwoLists_BothListsHaveElements_ReturnsMergedList()
        {
            // Arrange
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            // Act
            ListNode result = _solution.MergeTwoLists(list1, list2);

            // Assert
            ListNode expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));
            Assert.True(AreListsEqual(result, expected));
        }

        [Fact]
        public void MergeTwoLists_FirstListIsNull_ReturnsSecondList()
        {
            // Arrange
            ListNode? list1 = null;
            ListNode list2 = new ListNode(1, new ListNode(2, new ListNode(3)));

            // Act
            ListNode result = _solution.MergeTwoLists(list1, list2);

            // Assert
            ListNode expected = new ListNode(1, new ListNode(2, new ListNode(3)));
            Assert.True(AreListsEqual(result, expected));
        }

        [Fact]
        public void MergeTwoLists_SecondListIsNull_ReturnsFirstList()
        {
            // Arrange
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(3)));
            ListNode? list2 = null;

            // Act
            ListNode result = _solution.MergeTwoLists(list1, list2);

            // Assert
            ListNode expected = new ListNode(1, new ListNode(2, new ListNode(3)));
            Assert.True(AreListsEqual(result, expected));
        }

        [Fact]
        public void MergeTwoLists_BothListsAreNull_ReturnsEmptyList()
        {
            // Arrange
            ListNode? list1 = null;
            ListNode? list2 = null;

            // Act
            ListNode result = _solution.MergeTwoLists(list1, list2);

            // Assert
            Assert.Equal(0, result.val);
            Assert.Null(result.next);
        }

        [Fact]
        public void MergeTwoLists_SingleElementLists_ReturnsMergedList()
        {
            // Arrange
            ListNode list1 = new ListNode(1);
            ListNode list2 = new ListNode(2);

            // Act
            ListNode result = _solution.MergeTwoLists(list1, list2);

            // Assert
            ListNode expected = new ListNode(1, new ListNode(2));
            Assert.True(AreListsEqual(result, expected));
        }

        [Fact]
        public void MergeTwoLists_ListsWithDuplicateValues_ReturnsMergedList()
        {
            // Arrange
            ListNode list1 = new ListNode(1, new ListNode(1, new ListNode(1)));
            ListNode list2 = new ListNode(1, new ListNode(1, new ListNode(1)));

            // Act
            ListNode result = _solution.MergeTwoLists(list1, list2);

            // Assert - all values should be 1
            ListNode current = result;
            while (current != null)
            {
                Assert.Equal(1, current.val);
                current = current.next;
            }
        }

        [Fact]
        public void MergeTwoLists_ListsWithNegativeValues_ReturnsMergedList()
        {
            // Arrange
            ListNode list1 = new ListNode(-3, new ListNode(-1, new ListNode(0)));
            ListNode list2 = new ListNode(-2, new ListNode(1, new ListNode(2)));

            // Act
            ListNode result = _solution.MergeTwoLists(list1, list2);

            // Assert
            ListNode expected = new ListNode(-3, new ListNode(-2, new ListNode(-1, new ListNode(0, new ListNode(1, new ListNode(2))))));
            Assert.True(AreListsEqual(result, expected));
        }

        [Fact]
        public void MergeTwoLists_DifferentLengthLists_ReturnsMergedList()
        {
            // Arrange
            ListNode list1 = new ListNode(1, new ListNode(2));
            ListNode list2 = new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))));

            // Act
            ListNode result = _solution.MergeTwoLists(list1, list2);

            // Assert
            ListNode expected = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))));
            Assert.True(AreListsEqual(result, expected));
        }
    }
}
