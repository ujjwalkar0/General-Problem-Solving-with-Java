using Models;
using Problem_Solving;

namespace Test
{
    public class PalindromeLinkedListTest
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

        [Fact]
        public void IsPalindrome_Example1_EvenLengthPalindrome_ReturnsTrue()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 1, 2, 2, 1 });

            // Act
            bool result = _solution.IsPalindrome(head);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_Example2_NotPalindrome_ReturnsFalse()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 1, 2 });

            // Act
            bool result = _solution.IsPalindrome(head);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_SingleElement_ReturnsTrue()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 1 });

            // Act
            bool result = _solution.IsPalindrome(head);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_TwoSameElements_ReturnsTrue()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 1, 1 });

            // Act
            bool result = _solution.IsPalindrome(head);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_OddLengthPalindrome_ReturnsTrue()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 1, 2, 1 });

            // Act
            bool result = _solution.IsPalindrome(head);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_OddLengthNotPalindrome_ReturnsFalse()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 1, 2, 3 });

            // Act
            bool result = _solution.IsPalindrome(head);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_LongerPalindrome_ReturnsTrue()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 1, 2, 3, 2, 1 });

            // Act
            bool result = _solution.IsPalindrome(head);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_AllSameValues_ReturnsTrue()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 5, 5, 5, 5, 5 });

            // Act
            bool result = _solution.IsPalindrome(head);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_AllZeros_ReturnsTrue()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 0, 0, 0, 0 });

            // Act
            bool result = _solution.IsPalindrome(head);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_MaxValueDigits_ReturnsTrue()
        {
            // Arrange (using max constraint value 9)
            ListNode? head = CreateList(new int[] { 9, 0, 9 });

            // Act
            bool result = _solution.IsPalindrome(head);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_AlmostPalindrome_ReturnsFalse()
        {
            // Arrange - differs only in middle
            ListNode? head = CreateList(new int[] { 1, 2, 3, 4, 1 });

            // Act
            bool result = _solution.IsPalindrome(head);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindrome_LongEvenPalindrome_ReturnsTrue()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 });

            // Act
            bool result = _solution.IsPalindrome(head);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_FirstAndLastDiffer_ReturnsFalse()
        {
            // Arrange
            ListNode? head = CreateList(new int[] { 1, 2, 3, 2, 2 });

            // Act
            bool result = _solution.IsPalindrome(head);

            // Assert
            Assert.False(result);
        }
    }
}
