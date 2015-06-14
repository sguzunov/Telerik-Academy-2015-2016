namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong num)
        {
            this.Number = num;
        }

        public ulong Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }   
        }

        public int this[int pos]
        {
            get
            {
                if (pos < 0 || pos > 64)
                {
                    throw new IndexOutOfRangeException("Incorrect input data.Index must be [0...64].");
                }

                return ((int)(this.number >> pos) & 1);
            }
            set
            {
                if (pos < 0 || pos > 64)
                {
                    throw new ArgumentOutOfRangeException("Incorrect input data.Index must be [0...64].");
                }
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Incorrect input data for bit value.");
                }
                if (((int)(this.number >> pos) & 1) != value)
                {
                    this.Number ^= (1ul << pos);
                }
            }        
        }

        public override bool Equals(object obj)
        {
            BitArray64 objAsBit = obj as BitArray64;
            ulong firstNumber = this.Number;
            ulong secondNumber = objAsBit.Number;

            if (firstNumber == secondNumber)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public static bool operator ==(BitArray64 first,BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !(first.Equals(second));
        }
    }
}
