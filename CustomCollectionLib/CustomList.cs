using System.Collections;

namespace CustomCollectionLib
{
    public class CustomList<T> : IList<T>
    {
        //the node represents an element from the list
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

        private Node? head;
        private int count;

        //default constructor
        public CustomList()
        {
            head = null;
            count = 0;
        }

        //return the number of elements in the list 
        public int Count => count;

        //add an element in the beginning of the list 
        public void Add(T item)
        {
            Node newNode = new Node(item);
            newNode.Next = head;
            head = newNode;
            count++;
        }

        //ad an element to the list at the specified index
        public void Insert(int index, T item)
        {
            if (index < 0)
                throw new IndexOutOfRangeException();


            if (index == 0)
            {
                Add(item);
            }
            else
            {
                Node newNode = new Node(item);
                Node? current = head;

                for (int i = 0; i < index - 1; i++)
                    current = current.Next;

                newNode.Next = current.Next;
                current.Next = newNode;
                count++;
            }
        }

        //remove an item from the list at the specified index 
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();

            if (index == 0)
            {
                head = head.Next;
            }
            else
            {
                Node? current = head;
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;

                current.Next = current.Next.Next;
            }
            count--;
        }

        //remove all the items from a list 
        public void Clear()
        {
            head = null;
            count = 0;
        }

        //print the number of items in a list 
        public void PrintCount()
        {
            Console.WriteLine($"The number of elements in the list is: {Count}");
        }

        //an enumerator that can iterate through a collection of items of type T
        public IEnumerator<T> GetEnumerator()
        {
            Node? current = head;
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

        //an indexer that allows instances of a class or struct to be indexed just like arrays
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();

                Node? current = head;

                for (int i = 0; i < index; i++)
                    current = current.Next;

                return current.Data;
            }

            set
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();

                Node? current = head;
                for (int i = 0; i < index; i++)
                    current = current.Next;

                current.Data = value;
            }
        }

        public bool IsReadOnly => false;
        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }
        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }
        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

    }
}

