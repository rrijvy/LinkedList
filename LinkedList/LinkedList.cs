using System;

namespace LinkedList
{
    public class LinkedList<T> : ILinkedList<T> where T : class
    {
        private class Node
        {
            public T value;
            public Node next;

            public Node(T value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;
        private int size = 0;

        public int Size()
        {
            return size;
        }

        public void AddFirst(T value)
        {
            var node = new Node(value);

            if (first == null)
            {
                first = last = node;

                size++;
            }
            else
            {
                node.next = first;
                first = node;

                size++;
            }
        }

        public void AddLast(T value)
        {
            var node = new Node(value);

            if (first == null)
            {
                first = last = node;

                size++;
            }
            else
            {
                last.next = node;
                last = node;

                size++;
            }
        }

        public int DeleteFirst()
        {
            if (first == null)
                return -1;
            else
            {
                var deletedNode = first;
                first = deletedNode.next;
                deletedNode.next = null;

                size--;

                return 1;
            }
        }

        public int DeleteLast()
        {
            if (first == null)
                return -1;
            else
            {
                var currentNode = first;

                while (currentNode.next != last)
                {
                    currentNode = currentNode.next;
                }

                currentNode.next = null;

                last = currentNode;

                size--;

                return 1;
            }
        }

        public bool Contains(T value)
        {
            if (first == null)
                return false;
            else
            {
                var current = first;

                while (current.value != value)
                {
                    current = current.next;

                    if (current == null)
                        return false;
                }

                if (current.value == value)
                    return true;

                return false;
            }
        }

        public int IndexOf(T value)
        {
            int index = 0;

            if (first == null)
                return -1;
            else
            {
                var current = first;

                while (current != null)
                {
                    if (current.value == value)
                        return index;

                    current = current.next;

                    index++;
                }

                return -1;
            }
        }

        public T[] ToArray()
        {
            T[] array = new T[size];

            var current = first;

            int index = 0;

            while (current != null)
            {
                array[index] = current.value;

                current = current.next;

                index++;
            }

            return array;
        }
    }
}
