using System;
using System.Collections.Generic;

namespace StackToGetMin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Stack<int> s = new Stack<int>();
            MinStack minStack = new MinStack();
            minStack.Push(2);
            minStack.Push(0);
            minStack.Push(3);
            minStack.Push(0);
            minStack.GetMin(); // return -3
            minStack.Pop();
            minStack.GetMin();
            minStack.Pop();

            minStack.Top();    // return 0
            minStack.GetMin(); // return -2

        }
        public class MinStack
        {

            /** initialize your data structure here. */
            Stack<int> stack = new Stack<int>();
            Stack<int> min_vals = new Stack<int>();
            /// <summary>
            /// Check the count of mins_val if not 0 and x > mins_val.peek()
            /// make min = mins_val.peek() for every element added in stack add the relevant min value.
            /// 
            /// </summary>
            /// <param name="x"></param>
            public void Push(int x)
            {
                int min = x;

                if (min_vals.Count != 0 && min_vals.Peek()< min)
                {
                    min = min_vals.Peek();
                }

                stack.Push(x);
                min_vals.Push(min);
            }

            public void Pop()
            {
                stack.Pop();
                min_vals.Pop();
            }

            public int Top()
            {
                return stack.Peek();
            }

            public int GetMin()
            {

                return min_vals.Peek();


            }
        }

    }
}