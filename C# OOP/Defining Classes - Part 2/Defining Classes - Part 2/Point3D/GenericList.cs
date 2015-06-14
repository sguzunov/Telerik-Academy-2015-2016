namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GenericList<T>  where T : IComparable, new()      
    {
        private T[] elements;
        private int count = 0;
        private int capacity;      
       
        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            elements = new T[capacity]; 
        }

        public int Capacity
        {
            get 
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }

        public int Count 
        {
            get { return this.count; }

        }

        public void Add(T element)
        {
            if (this.count >= elements.Length)
            {
               // throw new ArgumentOutOfRangeException("Not enough space in the list!");
                AutoGrow();
            }

            this.elements[count] = element;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index >=this.count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        public void RemoveAt(int index)
        {
            if (index > this.elements.Length || index < 0)
            {
                throw new IndexOutOfRangeException(string.Format("Index must be between 1 and {0} !", this.capacity));
            }
            T[] current = new T[capacity - 1];
            for (int i = 0; i < index; i++)
            {
                current[i] = this.elements[i];
            }
            for (int i = index; i < this.elements.Length - 1; i++)
            {
                current[i] = this.elements[i + 1];
            }
            this.count--;
            this.elements = current;
        }

        public void InsertAt(int position,T newElement)
        {
            if (position > this.elements.Length || position < 0)
            {
                throw new IndexOutOfRangeException("Invalid position");
            }

            T[] current = new T[this.Capacity + 1];
            for (int i = 0; i < position; i++)
            {
                current[i] = this.elements[i];
            }

            current[position] = newElement;

            for (int i = position+1; i < this.elements.Length; i++)
            {
                current[i] = elements[i-1];
            }

            this.count++;
            this.elements = current;
        }

        public void Clear()
        {
            Array.Clear(elements, 0, this.Count);
            this.count = 0;            
        }

        public int IndexOf(T searchedElement)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].Equals(searchedElement))
                {
                    return i;
                    break;
                }
            }
            return -1;
        }

        private void AutoGrow()
        {
            this.Capacity = this.Capacity * 2;
            T[] newelements = new T[this.Capacity];

            for (int i = 0; i < this.count; i++)
            {
                newelements[i] = this.elements[i];
            }

            this.elements = newelements;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                result.Append(elements[i]);
                result.Append(',');                
            }
            result.Remove(this.count - 1, 1);

            return result.ToString();
        }

        public T Min()
        {
            T min = this.elements[0];

            for (int i = 0; i < this.Count; i++)
            {
                if (elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this.elements[0];

            for (int i = 0; i < this.Count; i++)
            {
                if (elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }


    }
}
