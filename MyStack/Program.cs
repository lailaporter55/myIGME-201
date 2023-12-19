using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    internal class Program
    {
        class Stack
        {
            private List<int> stack = new List<int>();
            public Stack(List<int> stack)
            {
                this.stack = stack;
            }

            //add new data to the top of the stack 
            public void Push(int n)
            {
                stack.Add(n);
            }

            //remove & and return the data on top
            public int Pop()
            {
                if (stack.Count != 0)
                {
                    //get the lat element 
                    int n = stack[stack.Count - 1];
                    stack.RemoveAt(stack.Count - 1);
                    return n;
                }
                else
                {
                    Console.WriteLine("stack is empty");
                    return 0;
                }
            }

            //look at the top of the stack, return the data
            public int Peek()
            {
                if (stack.Count != 0)
                {
                    //similar to pop, only returning the int not removing
                    int n = stack[stack.Count - 1];
                    return n;
                }
                else
                {
                    Console.WriteLine("stack is empty");
                    return 0;
                }
            }
            static void Main(string[] args)
            {
                //init a list 
                List<int> stackList = new List<int>();
                //create a new instance of Stack to test out the methods
                Stack stack = new Stack(stackList);
                Console.WriteLine("stack with nothing", stack);
                //test push, adds to the stack 
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(5);
                stack.Push(7);
                stack.Push(9);
                Console.WriteLine("stack with push", stack);
                //test pop, removes and returns
                stack.Pop();
                stack.Pop();
                Console.WriteLine("stack after popping twice", stack);
                //test peek
                Console.WriteLine("stack with peek", stack.Peek());

            }
        }

        class MyQueue
        {
            private List<int> queue = new List<int>();
            public MyQueue(List<int> queue)
            {
                this.queue = queue;
            }

            //enqueue: add new data to the back of the queue
            public void Enqueue(int n)
            {
                queue.Add(n);
            }
            //dequeue: remove & return the data in the front of the queue
            public int Dequeue()
            {
                
                if (queue.Count != 0)
                {
                    int n = queue[0];
                    queue.RemoveAt(0);
                    return n;
                }
                //check if queue is empty
                else
                {
                    Console.WriteLine("Queue is empty");
                    return 0;
                }
            }
            //peek: look at the front of the queue, return the data, DONT remove it
            public int Peek()
            {
                //return the first element
                if(queue.Count != 0)
                {
                    return (queue[0]);
                }
                else 
                { 
                    Console.WriteLine("Queue is empty");
                    return 0; 
                }
            }
            static void Main(string[] args)
            {
                List<int> queueList = new List<int>();
                MyQueue queue = new MyQueue(queueList);
                Console.WriteLine("Queue before", queue);
                //testing enqueue
                queue.Enqueue(5);
                queue.Enqueue(4);
                queue.Enqueue(3);
                queue.Enqueue(2);
                queue.Enqueue(1);
                Console.WriteLine("Queue after enqueue", queue);
                //testing dequeue
                queue.Dequeue();
                queue.Dequeue();
                Console.WriteLine("Queue after dequeue", queue);
                //testing peek
                Console.WriteLine("Peeking into queue",queue.Peek());
            }
        }
        
    }
}
