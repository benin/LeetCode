using NUnit.Framework;
using FluentAssertions;

namespace MinStack.UnitTests
{
    public class SolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MinStackLeetCodeExampleTest()
        {
            var minStack = new MinStack();

            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);

            minStack.GetMin().Should().Be(-3);
            minStack.Pop();
            minStack.Top().Should().Be(0);
            minStack.GetMin().Should().Be(-2);
        }
    }
}