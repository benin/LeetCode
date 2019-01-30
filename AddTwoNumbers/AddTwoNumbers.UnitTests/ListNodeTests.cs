using NUnit.Framework;
using AddTwoNumbers;
using System.Collections;
using FluentAssertions;


namespace AddTwoNumbers.UnitTests
{
    public class ListNodeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateFullListTest()
        {
            var list = new ListNode(new [] {0, 1, 2, 3, 4, 5});
            for (int i = 0; i <= 5; i++)
            {
                list.val.Should().Be(i);
                if (i < 5)
                    list.next.Should().NotBeNull();
                else
                    list.next.Should().BeNull();    
                list = list.next;
            }
        }

        [Test]
        public void CreateEmptyListTest()
        {
            var list = new ListNode(new int[]{});
            
            list.val.Should().Be(0);
            list.next.Should().BeNull();
        }

        [Test]
        public void CreateOneItemListTest()
        {
            var list = new ListNode(new int[]{7});
            
            list.val.Should().Be(7);
            list.next.Should().BeNull();
        }

        [Test]
        public void ListNodeOneItemEquals()
        {
            var l1 = new ListNode(new int[]{7});
            var l2 = new ListNode(new int[]{7});
            
            l1.Should().Be(l2);
            l2.Should().Be(l1);
        }

        [Test]
        public void ListNodeEmptyEquals()
        {
            var l1 = new ListNode(new int[]{});
            var l2 = new ListNode(new int[]{});
            
            l1.Should().Be(l2);
            l2.Should().Be(l1);
        }

        [Test]
        public void ListNodeFullEquals()
        {
            var l1 = new ListNode(new [] {0, 1, 2, 3, 4, 5, 6, 7});
            var l2 = new ListNode(new [] {0, 1, 2, 3, 4, 5, 6, 7});
            
            l1.Should().Be(l2);
            l2.Should().Be(l1);
        }

        [Test]
        public void ListNode3Equals()
        {
            var l1 = new ListNode(new[] { 4, 6, 5 });
            var l2 = new ListNode(new[] { 4, 6, 5 });

            l1.Should().Be(l2);
            l2.Should().Be(l1);
        }

        [Test]
        public void ListNodeFullNotEquals()
        {
            var l1 = new ListNode(new [] {0, 1, 2, 3, 4, 5});
            var l2 = new ListNode(new [] {0, 1, 2, 3, 4, 0});
            
            l1.Should().NotBe(l2);
            l2.Should().NotBe(l1);
        }

        [Test]
        public void ListNodeFullDifferNotEquals()
        {
            var l1 = new ListNode(new [] {0, 1, 2, 3, 4, 5});
            var l2 = new ListNode(new [] {4, 3});
            
            l1.Should().NotBe(l2);
            l2.Should().NotBe(l1);
        }
    }

}