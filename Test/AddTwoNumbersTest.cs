using Models;
using Problem_Solving;

namespace Test
{
    public class AddTwoNumbersTest
    {
        private readonly Solution _solution = new Solution();

        // Helper method to create a linked list from an array
        private ListNode CreateList(int[] values)
        {
            if (values.Length == 0)
                return null!;

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
        private int[] ListToArray(ListNode node)
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
        public void AddTwoNumbers_Example1_Returns708()
        {
            // Arrange: 342 + 465 = 807
            // l1 = [2,4,3], l2 = [5,6,4] -> [7,0,8]
            ListNode l1 = CreateList(new int[] { 2, 4, 3 });
            ListNode l2 = CreateList(new int[] { 5, 6, 4 });

            // Act
            ListNode result = _solution.AddTwoNumbers(l1, l2);

            // Assert
            Assert.Equal(new int[] { 7, 0, 8 }, ListToArray(result));
        }

        [Fact]
        public void AddTwoNumbers_Example2_BothZeros_ReturnsZero()
        {
            // Arrange: 0 + 0 = 0
            ListNode l1 = CreateList(new int[] { 0 });
            ListNode l2 = CreateList(new int[] { 0 });

            // Act
            ListNode result = _solution.AddTwoNumbers(l1, l2);

            // Assert
            Assert.Equal(new int[] { 0 }, ListToArray(result));
        }

        [Fact]
        public void AddTwoNumbers_Example3_DifferentLengthsWithCarry_ReturnsCorrectResult()
        {
            // Arrange: 9999999 + 9999 = 10009998
            // l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9] -> [8,9,9,9,0,0,0,1]
            ListNode l1 = CreateList(new int[] { 9, 9, 9, 9, 9, 9, 9 });
            ListNode l2 = CreateList(new int[] { 9, 9, 9, 9 });

            // Act
            ListNode result = _solution.AddTwoNumbers(l1, l2);

            // Assert
            Assert.Equal(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 }, ListToArray(result));
        }

        [Fact]
        public void AddTwoNumbers_SingleDigitsNoCarry_ReturnsSum()
        {
            // Arrange: 2 + 3 = 5
            ListNode l1 = CreateList(new int[] { 2 });
            ListNode l2 = CreateList(new int[] { 3 });

            // Act
            ListNode result = _solution.AddTwoNumbers(l1, l2);

            // Assert
            Assert.Equal(new int[] { 5 }, ListToArray(result));
        }

        [Fact]
        public void AddTwoNumbers_SingleDigitsWithCarry_ReturnsTwoDigits()
        {
            // Arrange: 5 + 7 = 12
            ListNode l1 = CreateList(new int[] { 5 });
            ListNode l2 = CreateList(new int[] { 7 });

            // Act
            ListNode result = _solution.AddTwoNumbers(l1, l2);

            // Assert
            Assert.Equal(new int[] { 2, 1 }, ListToArray(result));
        }

        [Fact]
        public void AddTwoNumbers_DifferentLengths_ShorterFirst_ReturnsCorrectSum()
        {
            // Arrange: 99 + 1 = 100
            // l1 = [9,9], l2 = [1] -> [0,0,1]
            ListNode l1 = CreateList(new int[] { 9, 9 });
            ListNode l2 = CreateList(new int[] { 1 });

            // Act
            ListNode result = _solution.AddTwoNumbers(l1, l2);

            // Assert
            Assert.Equal(new int[] { 0, 0, 1 }, ListToArray(result));
        }

        [Fact]
        public void AddTwoNumbers_AllNines_PropagatesCarryToNewDigit()
        {
            // Arrange: 999 + 1 = 1000
            ListNode l1 = CreateList(new int[] { 9, 9, 9 });
            ListNode l2 = CreateList(new int[] { 1 });

            // Act
            ListNode result = _solution.AddTwoNumbers(l1, l2);

            // Assert
            Assert.Equal(new int[] { 0, 0, 0, 1 }, ListToArray(result));
        }

        [Fact]
        public void AddTwoNumbers_NoCarryMultipleDigits_ReturnsCorrectSum()
        {
            // Arrange: 123 + 456 = 579
            // l1 = [3,2,1], l2 = [6,5,4] -> [9,7,5]
            ListNode l1 = CreateList(new int[] { 3, 2, 1 });
            ListNode l2 = CreateList(new int[] { 6, 5, 4 });

            // Act
            ListNode result = _solution.AddTwoNumbers(l1, l2);

            // Assert
            Assert.Equal(new int[] { 9, 7, 5 }, ListToArray(result));
        }

        [Fact]
        public void AddTwoNumbers_ZeroAndNumber_ReturnsNumber()
        {
            // Arrange: 0 + 123 = 123
            ListNode l1 = CreateList(new int[] { 0 });
            ListNode l2 = CreateList(new int[] { 3, 2, 1 });

            // Act
            ListNode result = _solution.AddTwoNumbers(l1, l2);

            // Assert
            Assert.Equal(new int[] { 3, 2, 1 }, ListToArray(result));
        }

        [Fact]
        public void AddTwoNumbers_LongNumbers_ReturnsCorrectSum()
        {
            // Arrange: 9876543 + 1234567 = 11111110
            // l1 = [3,4,5,6,7,8,9], l2 = [7,6,5,4,3,2,1] -> [0,1,1,1,1,1,1,1]
            ListNode l1 = CreateList(new int[] { 3, 4, 5, 6, 7, 8, 9 });
            ListNode l2 = CreateList(new int[] { 7, 6, 5, 4, 3, 2, 1 });

            // Act
            ListNode result = _solution.AddTwoNumbers(l1, l2);

            // Assert
            Assert.Equal(new int[] { 0, 1, 1, 1, 1, 1, 1, 1 }, ListToArray(result));
        }
    }
}
