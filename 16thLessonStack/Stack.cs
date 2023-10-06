using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16thLessonStack
{
    public class Stack<T> : IEnumerable<T>
    {
        private T[] _values = new T[50];
        private int _topIndex = 0;

        public void Push(T value)
        {
            try
            {
            _values[_topIndex] = value;
            _topIndex++;
            }
            catch(IndexOutOfRangeException)
            {
                throw new InvalidOperationException("The stack is full, clear it out before adding new elements.");
            }
        }

        public T Pop()
        {
            try
            {
            _topIndex--;
            return _values[_topIndex];
            }
            catch(IndexOutOfRangeException)
            {
                throw new InvalidOperationException("Stack is empty, cannot pop elements.");
            }
        }

        public T Peek()
        {
            try
            {
                return _values[_topIndex - 1];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException("Stack is empty, cannot peek elements.");
            }
            
        }
        
        public void Clear()
        {
            _topIndex = 0;
        }

        public T[] CopyTo(T[] arr)
        {
            int i = 0;
            foreach(T t in this)
            {
                arr[i] = t;
                i++;
            }
            return arr;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = _topIndex - 1; i >= 0; i--)
            {
                yield return _values[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator() 
        { 
            return GetEnumerator();
        }

        public int Count => _topIndex;

        public int MaxCapacity => _values.Length;

    }
}
