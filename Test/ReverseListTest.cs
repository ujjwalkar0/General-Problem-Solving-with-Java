using Models;
using Problem_Solving;

namespace Test
{
    public class ReverseListTest
    {
        private readonly Solution _solution = new Solution();

        // Helper method to create a linked list from an array
        private ListNode? CreateList(int[] values)
        {
            if (values.Length == 0)
                return null;

            ListNode head = new ListNode(values[0]);
            ListNode current = head;
            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }
            return head;
        }

        // Helper method to convert linked list to array for comparison
        private int[] ListToArray(ListNode? node)
        {
            var result = new List<int>();
            while (node != null)
            {
                result.Add(node.val);
                node = node.next;
            }
            return result.ToArray();
        }

        [Fact]
        public void ReverseList_Example1_FiveElements_ReturnsReversed()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 1, 2, 3, 4, 5 });

            // Act
            ListNode? result = _solution.ReverseList(head);

            // Assert
            Assert.Equal(new int[] { 5, 4, 3, 2, 1 }, ListToArray(result));
        }

        [Fact]
        public void ReverseList_Example2_TwoElements_ReturnsReversed()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 1, 2 });

            // Act
            ListNode? result = _solution.ReverseList(head);

            // Assert
            Assert.Equal(new int[] { 2, 1 }, ListToArray(result));
        }

        [Fact]
        public void ReverseList_Example3_EmptyList_ReturnsNull()
        {
            // Arrange
            ListNode? head = null;

            // Act
            ListNode? result = _solution.ReverseList(head);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void ReverseList_SingleElement_ReturnsSameElement()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 1 });

            // Act
            ListNode? result = _solution.ReverseList(head);

            // Assert
            Assert.Equal(new int[] { 1 }, ListToArray(result));
        }

        [Fact]
        public void ReverseList_ThreeElements_ReturnsReversed()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 1, 2, 3 });

            // Act
            ListNode? result = _solution.ReverseList(head);

            // Assert
            Assert.Equal(new int[] { 3, 2, 1 }, ListToArray(result));
        }

        [Fact]
        public void ReverseList_NegativeValues_ReturnsReversed()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { -5000, 0, 5000 });

            // Act
            ListNode? result = _solution.ReverseList(head);

            // Assert
            Assert.Equal(new int[] { 5000, 0, -5000 }, ListToArray(result));
        }

        [Fact]
        public void ReverseList_DuplicateValues_ReturnsReversed()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 1, 1, 2, 2, 3 });

            // Act
            ListNode? result = _solution.ReverseList(head);

            // Assert
            Assert.Equal(new int[] { 3, 2, 2, 1, 1 }, ListToArray(result));
        }

        [Fact]
        public void ReverseList_AllSameValues_ReturnsReversed()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 5, 5, 5, 5 });

            // Act
            ListNode? result = _solution.ReverseList(head);

            // Assert
            Assert.Equal(new int[] { 5, 5, 5, 5 }, ListToArray(result));
        }

        [Fact]
        public void ReverseList_LongList_ReturnsReversed()
        {
            // Arrange
            int[] input = Enumerable.Range(1, 100).ToArray();
            int[] expected = Enumerable.Range(1, 100).Reverse().ToArray();
            ListNode? head = CreateList(input);

            // Act
            ListNode? result = _solution.ReverseList(head);

            // Assert
            Assert.Equal(expected, ListToArray(result));
        }
    }
}
