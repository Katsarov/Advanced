using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingCustomDataStructure
{
    public class CustomList
    {
        private const int INITIAL_CAPACITY = 2;

        private readonly int[] items;

        public CustomList()
        {
            this.items = new int[INITIAL_CAPACITY];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (!this.IsValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.items[index];
            }
            private set
            {
                if (!this.IsValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.items[index] = value;
            }
        }

        private bool IsValidIndex(int index)
            => index < this.Count;
    }
}
