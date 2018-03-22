using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class DynamicArray<T> where T: new()
    {
        private int capacity;
        public int Capacity
        {
            get { return capacity; }
        }
        private T[] array;
        private int length = 0;
        public int Length
        {
            get { return length; }
        }
        public DynamicArray()
        {
            this.array = new T[8];
            this.capacity = 8;
        }
        public DynamicArray(int capacity)
        {
            array = new T[capacity];
            this.capacity = capacity;
        }
        public DynamicArray(T[] ts)
        {
            array = ts;
            this.capacity = ts.Length;
            this.length = ts.Length;
        }
        public void Add(T element)
        {
            if (length == capacity)
            {
                capacity *= 2;
                T[] temp = array;
                this.array.CopyTo(temp, 0);
                this.array = new T[capacity];
                temp.CopyTo(array, 0);
                array[length] = element;
                length++;

            }
            else
            {
                array[length] = element;
                length++;
            }
        }
        public T this[int index]
        {
            get
            {
                if (index > capacity && index <0)
                {
                    throw new IndexOutOfRangeException("Index out of range exception");
                }
                else
                {
                    return array[index];
                }
            }
            set
            {
                if (index > capacity)
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
                else
                {
                    array[index] = value;
                    if (index > length - 1)
                    {
                        length++;
                    }
                }
            }
        }
        public void AddRange(T[] ts)
        {
            if (ts.Length + this.length > this.capacity)
            {
                this.capacity *= ((this.length + ts.Length) / this.capacity) + 1;
                T[] temp = array;
                this.array = new T[capacity];
                temp.CopyTo(array, 0);
                ts.CopyTo(array, length);
                this.length = length + ts.Length;
            }
            else
            {
                T[] temp = array;
                this.array = new T[capacity];
                temp.CopyTo(array, 0);
                ts.CopyTo(array, length);
                this.length = length + ts.Length;
            }
        }
        public bool Remove(int index)
        {
            if (index > length - 1 || index < 0)
            {
                return false;
            }
            else
            {
                T[] temp = new T[length - index - 1];
                Array.ConstrainedCopy(array,index+1,temp,0,length-index-1);
                temp.CopyTo(array,index);
                length--;
                return true;
            }
        }
        public void Insert(int index, T ts)
        {
            if (index > length || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index!");
            }
            else
            {
                if (capacity == length)
                {
                    T[] temp2 = array;
                    capacity *= 2;
                    this.array = new T[capacity];
                    temp2.CopyTo(array,0);
                }
                T[] temp = new T[length - index+1];
                Array.ConstrainedCopy(array, index, temp, 1, length - index);
                temp[0] = ts;
                temp.CopyTo(array, index);
                length++;
            }
        }
    }
}
