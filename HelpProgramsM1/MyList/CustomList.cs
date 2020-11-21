namespace MyList
{
    using System;
    using System.Text;

    public class CustomList
    {
        private const int INTERNAL_ARRAY_INITIAL_CAPACITY = 2;
        private int currentCapacity;
        private int[] internalArray;

        public CustomList()
        {
            this.currentCapacity = INTERNAL_ARRAY_INITIAL_CAPACITY;
            this.internalArray = new int[this.currentCapacity];
            this.Count = 0;
        }

        public int Count { get; private set; }

        public int this[int index] 
        {
            get
            {
                ValidateIndex(index);
                return this.internalArray[index];
            }
            set
            {
                ValidateIndex(index);
                this.internalArray[index] = value;
            }
        }

        public void Add(int element)
        {
            if(ResizeNecessary()) 
                Resize();
            this.internalArray[this.Count] = element;
            this.Count++;
        }

        public int RemoveAt(int indexAt)
        {
            ValidateIndex(indexAt);
            int removedElement = this.internalArray[indexAt];
            ShiftLeft(indexAt);
            if (ShrinkNecessary())
                Shrink();
            this.Count--;
            return removedElement;
        }

        public void InsertAt(int indexAt, int element)
        {
            ValidateIndex(indexAt);
            this.Count++;
            if (ResizeNecessary())
                Resize();
            ShiftRight(indexAt);
            this.internalArray[indexAt] = element;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.internalArray[i] == element)
                    return true;
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            ValidateIndex(firstIndex);
            ValidateIndex(secondIndex);
            int tempElement = this.internalArray[firstIndex];
            this.internalArray[firstIndex] = this.internalArray[secondIndex];
            this.internalArray[secondIndex] = tempElement;
        }

        public void Reverse()
        {
            for (int i = 0; i < this.Count / 2; i++)
            {
                Swap(i, this.Count - 1 - i);
            }
        }

        private bool ResizeNecessary() => this.Count >= this.currentCapacity;
        private bool ShrinkNecessary() => this.Count <= this.currentCapacity / 4;

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Count)
                throw new ArgumentOutOfRangeException();
        }

        private void Resize()
        {
            int[] tempArray = new int[this.currentCapacity * 2];
            Array.Copy(this.internalArray, tempArray, this.currentCapacity);
            this.internalArray = tempArray;
            this.currentCapacity = this.internalArray.Length;
        }

        private void ShiftLeft(int startIndex)
        {
            for (int i = startIndex; i < this.Count -1; i++)
            {
                this.internalArray[i] = this.internalArray[i + 1];
            }
            this.internalArray[this.Count - 1] = default;
        }

        private void ShiftRight(int startIndex)
        {
            for (int i = this.Count; i > startIndex; i--)
            {
                this.internalArray[i] = this.internalArray[i - 1];
            }
            this.internalArray[startIndex] = default;
        }

        private void Shrink()
        {
            int[] tempArray = new int[this.currentCapacity / 2];
            for (int i = 0; i < this.Count; i++)
            {
                tempArray[i] = this.internalArray[i];
            }
            this.internalArray = tempArray;
            this.currentCapacity /= 2;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int element in this.internalArray)
                sb.Append(element + ", ");
            return sb.ToString().TrimEnd(new char[]{',', ' ' });
        }
    }
}
