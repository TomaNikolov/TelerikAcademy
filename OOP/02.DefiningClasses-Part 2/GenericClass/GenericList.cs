namespace GenericClass
{
    using System;
    using System.Text;

    public class GenericList<T>
            where T : IComparable
    {
        private const int defaultLenght = 8;
        private const int doubleSize = 2;
        private const int startElementInList = 0;

        private T[] array;
        private int capacity;

        public GenericList()
            : this(defaultLenght)
        {

        }
        public GenericList(int capacity)
        {
            this.Count = startElementInList;
            this.Capacity = capacity;
            this.array = new T[this.Capacity];
        }


        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                if (value < 1)
                {
                    value = defaultLenght;
                }
                this.capacity = value;
            }
        }
        //Accessing element by index
        public T this[int index]
        {

            get
            {
                CheckRange(index);
                return this.array[index];
            }
            set
            {
                CheckRange(index);
                this.array[index] = value;

            }
        }

        /// <summary>
        ///Adding element 
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            CheckForCapacityReached();
            this.array[this.Count] = element;
            this.Count++;
        }
        /// <summary>
        /// Remove element by index
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            CheckRange(index);
            T[] result = new T[this.Capacity];
            for (int oldElement = 0, newElement = 0; oldElement < this.Count; oldElement++, newElement++)
            {
                if (oldElement == index)
                {
                    oldElement++;
                }

                result[newElement] = this.array[oldElement];
            }
            this.array = result;
            this.Count--;
        }

        /// <summary>
        /// Insert element at given position
        /// </summary>
        /// <param name="index"></param>
        /// <param name="element"></param>
        public void InsertAt(int index, T element)
        {
            CheckRange(index);
            CheckForCapacityReached();
            T[] result = new T[this.Capacity];
            for (int oldElement = 0, newElement = 0; oldElement < this.Count; oldElement++, newElement++)
            {
                if (newElement == index)
                {
                    result[newElement] = element;
                    newElement++;
                }
                result[newElement] = this.array[oldElement];
            }
            this.array = result;
            this.Count++;
        }

        /// <summary>
        ///  Finding element by its value
        ///  Return index of element if find match
        ///  and -1 if list does not contain this element.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public int FindElement(T element)
        {
            const int notFound = -1;

            int result = int.MinValue;
            for (int index = 0; index < this.Count; index++)
            {
                if (this.array[index].Equals(element))
                {
                    result = index;
                }
            }
            if (result < 0)
            {
                result = notFound;
            }
            return result;
        }

        /// <summary>
        /// Clear the list
        /// </summary>
        public void Clear()
        {
            this.array = new T[this.Capacity];
            this.Count = startElementInList;
        }

        private void CheckRange(int index)
        {

            if (index < 0 || index >= this.Capacity)
            {
                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>
        /// Return list to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int index = startElementInList; index < this.Count; index++)
            {
                result.Append(this.array[index]);
                if (index != this.Count - 1)
                {
                    result.Append(", ");
                }
            }
            return result.ToString();
        }
        /// <summary>
        /// Return minimal element in list
        /// </summary>
        /// <returns></returns>
        public T Min()
        {
            T min = this.array[startElementInList];

            for (int index = 1; index < this.Count; index++)
            {
                int result = min.CompareTo(this.array[index]);
                if (result > 0)
                {
                    min = this.array[index];
                }

            }
            return min;
        }
        //Problem 7. Min and Max
        //need to add a generic constraints IComparable
        /// <summary>
        /// Return maximal element in list
        /// </summary>
        /// <returns></returns>
        public T Max()
        {
            T max = this.array[startElementInList];

            for (int index = 1; index < this.Count; index++)
            {
                int result = max.CompareTo(this.array[index]);
                if (result < 0)
                {
                    max = this.array[index];
                }

            }
            return max;
        }

        //Problem 6. Auto-grow
        private T[] AutoGrow(T[] array)
        {
            T[] result = new T[this.Capacity * doubleSize];
            for (int index = 0; index < this.Count; index++)
            {
                result[index] = array[index];
            }
            this.Capacity *= doubleSize;
            return result;
        }

        private void CheckForCapacityReached()
        {
            if (this.Count >= this.Capacity - 1)
            {
                this.array = AutoGrow(this.array);
            }
        }
    }
}
