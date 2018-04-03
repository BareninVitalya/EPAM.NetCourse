using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class DynamicArray<T> : IEnumerable where T : IComparable<T>, new()
    {
        public int Capacity
        {
            get { return array.Length; }
        }
        private T[] array;
        private int length = 0;
        public int Length
        {
            get { return length; }
        }
        public void Sort()
        {
            T temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public DynamicArray()
        {
            this.array = new T[8];
        }
        public DynamicArray(int capacity)
        {
            array = new T[capacity];
        }
        public DynamicArray(T[] ts)
        {
            array = ts ?? throw new ArgumentException("Array is null!");
            this.length = ts.Length;
        }
        public void Add(T element)
        {
            if (element == null)
            {
                throw new ArgumentException("Element is null!");
            }
            Insert(length, element);
        }
        public T this[int index]
        {
            get
            {
                IsViladIndex(index);
                return array[index];

            }
            set
            {
                IsViladIndex(index);
                array[index] = value;
                if (index > length - 1)
                {
                    length++;
                }
            }
        }
        public void AddRange(T[] ts)
        {
            if (ts == null)
            {
                throw new ArgumentException("Array is null!");
            }
            if (ts.Length + this.length > Capacity)
            {
                int newCapacity = Capacity * (((this.length + ts.Length) / Capacity) + 1);
                ReSize(newCapacity);
                ts.CopyTo(array, length);
                this.length = length + ts.Length;
            }
            else
            {
                ReSize(Capacity, length);
                ts.CopyTo(array, length);
                this.length = length + ts.Length;
            }
        }
        public void RemoveAt(int index)
        {
            IsViladIndex(index);
            T[] temp = new T[length - index - 1];
            Array.ConstrainedCopy(array, index + 1, temp, 0, length - index - 1);
            temp.CopyTo(array, index);
            length--;
        }
        public bool Remove(T ts)
        {
            if (ts == null)
            {
                return false;
            }
            else
            {
                int index = Array.IndexOf(array, ts);
                if (index == -1)
                {
                    return false;
                }
                T[] temp = new T[length - index - 1];
                Array.ConstrainedCopy(array, index + 1, temp, 0, length - index - 1);
                temp.CopyTo(array, index);
                length--;
                return true;
            }
        }
        public void Insert(int index, T ts)
        {
            IsViladIndex(index);
            if (Capacity == length)
            {
                int newCapacity = Capacity * 2;
                ReSize(newCapacity);
            }
            T[] temp = new T[length - index + 1];
            Array.ConstrainedCopy(array, index, temp, 1, length - index);
            temp[0] = ts;
            temp.CopyTo(array, index);
            length++;
        }
        private T[] ReSize(int capacity, int size = 0)
        {
            T[] temp = this.array;
            array.CopyTo(temp, 0);
            array = new T[capacity];
            temp.CopyTo(array, size);
            return array;
        }
        private void IsViladIndex(int index)
        {
            if (index > length || index < 0 || index > Capacity)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)new DynamicArrayEnumenator<T>(this);
        }
    }
    public class DynamicArrayEnumenator<T> : IEnumerator where T : IComparable<T>, new()
    {
        private int position = -1;
        private DynamicArray<T> dynamicArray;
        public DynamicArrayEnumenator( DynamicArray<T> dynamicArray)
        {
            this.dynamicArray = dynamicArray;
        }
        public object Current
        {
            get
            {
                return dynamicArray[position];
            }
        }

        public bool MoveNext()
        {
            if (position == dynamicArray.Length)
            {
                return false;
            }
            else
            {
                position++;
                return true;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
