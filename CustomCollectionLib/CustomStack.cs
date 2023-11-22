using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollectionLib
{
    public class CustomStack<T> : IEnumerable<T>
    {
        //the node represents an element from the stack
        private class Node
        {
            public Node? Next { get; set; }
            public T Data { get; set; }


            public Node(T data)
            {
                Next = null;
                Data = data;
            }
        }

        private Node? top;
        private int count;

        //return the number of elements in the stack
        public int Count => count;

        //add an element to the stack 
        public void Push(T item)
        {
            Node newNode = new Node(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }

        //remove an element from the stack 
        public T Pop()
        {
            if (count == 0)
                throw new InvalidOperationException();
            else
            {
                T data = top.Data;
                top = top.Next;
                count--;
                return data;
            }

        }

        //an enumerator that can iterate through a collection of items of type T
        public IEnumerator<T> GetEnumerator()
        {
            Node? current = top;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
