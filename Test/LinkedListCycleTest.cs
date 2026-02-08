using Problem_Solving;
using Models;
using Xunit;

namespace Test
{
    public class LinkedListCycleTest
    {
        private readonly Solution _solution = new Solution();

        [Fact]
        public void HasCycle_Example1_ReturnsTrue()
        {
            // head = [3,2,0,-4], pos = 1
            var nodes = new ListNode[] {
                new ListNode(3),
                new ListNode(2),
                new ListNode(0),
                new ListNode(-4)
            };
            for (int i = 0; i < nodes.Length - 1; i++)
                nodes[i].next = nodes[i+1];
            nodes[nodes.Length-1].next = nodes[1]; // cycle to index 1
            Assert.True(_solution.HasCycle(nodes[0]));
        }

        [Fact]
        public void HasCycle_Example2_ReturnsTrue()
        {
            // head = [1,2], pos = 0
            var nodes = new ListNode[] {
                new ListNode(1),
                new ListNode(2)
            };
            nodes[0].next = nodes[1];
            nodes[1].next = nodes[0]; // cycle to index 0
            Assert.True(_solution.HasCycle(nodes[0]));
        }

        [Fact]
        public void HasCycle_Example3_ReturnsFalse()
        {
            // head = [1], pos = -1
            var node = new ListNode(1);
            Assert.False(_solution.HasCycle(node));
        }

        [Fact]
        public void HasCycle_EmptyList_ReturnsFalse()
        {
            Assert.False(_solution.HasCycle(null));
        }

        [Fact]
        public void HasCycle_SingleNodeCycle_ReturnsTrue()
        {
            var node = new ListNode(1);
            node.next = node;
            Assert.True(_solution.HasCycle(node));
        }

        [Fact]
        public void HasCycle_LongListNoCycle_ReturnsFalse()
        {
            var nodes = new ListNode[10000];
            for (int i = 0; i < nodes.Length; i++)
                nodes[i] = new ListNode(i);
            for (int i = 0; i < nodes.Length - 1; i++)
                nodes[i].next = nodes[i+1];
            Assert.False(_solution.HasCycle(nodes[0]));
        }

        [Fact]
        public void HasCycle_LongListWithCycle_ReturnsTrue()
        {
            var nodes = new ListNode[10000];
            for (int i = 0; i < nodes.Length; i++)
                nodes[i] = new ListNode(i);
            for (int i = 0; i < nodes.Length - 1; i++)
                nodes[i].next = nodes[i+1];
            nodes[nodes.Length-1].next = nodes[5000]; // cycle to index 5000
            Assert.True(_solution.HasCycle(nodes[0]));
        }
    }
}
