using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public interface ILinkedList<T> where T : class
    {
        int Size();
        void AddFirst(T value);
        void AddLast(T value);
        int DeleteFirst(T value);
        int DeleteLast(T value);
        bool Contains(T value);
        int IndexOf(T value);
        T[] ToArray(T value);
    }
}
