using System;
using System.Collections.Generic;

namespace MinStack
{
    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
    public class MinStack
    {
        private readonly LinkedList<LinkedListNode<int>> _stack = new LinkedList<LinkedListNode<int>>();
        private readonly LinkedList<int> _minList = new LinkedList<int>();

        public MinStack()
        {
        }

        public void Push(int x)
        {
            LinkedListNode<int> newMinNode;

            // Add minimal sorted list
            if (_minList.First == null)
            {
                newMinNode = _minList.AddFirst(x);
            }
            else
            {

                var node = _minList.First;
                while (node.Next != null && x > node.Value)
                {
                    node = node.Next;
                }
                newMinNode = x > node.Value ? 
                    _minList.AddAfter(node, x) : 
                    _minList.AddBefore(node, x);
            }

            // Add to the stack
            _stack.AddLast(newMinNode);
        }

        public void Pop()
        {
            var removedNode = _stack.Last.Value;
            _stack.RemoveLast();

            _minList.Remove(removedNode);
        }

        public int Top()
        {
            return _stack.Last.Value.Value;
        }

        public int GetMin()
        {
            return _minList.First.Value;
        }
    }
}
