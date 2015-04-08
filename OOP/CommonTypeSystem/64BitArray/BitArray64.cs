namespace _64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable
    {
        private const int MaxArrayCapacity = 63;

        private ulong bitvalue;

        public BitArray64(ulong bitValue)
        {
            this.bitvalue = bitValue;
        }

        public int this[int pos]
        {
            get
            {
                if (pos < 0 || pos > MaxArrayCapacity)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range");
                }
                return (int)((this.bitvalue >> pos) & 1);
            }
            set
            {
                if (pos < 0 || pos > MaxArrayCapacity)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range");
                }
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Value must be 0 or 1");
                }
                if (value == 1)
                {
                    this.bitvalue = this.bitvalue | ((ulong)1 << pos);
                }
                else
                {
                    this.bitvalue = this.bitvalue & (~((ulong)1 << pos));
                }
            }
        }

        public override bool Equals(object obj)
        {
            var objAsNum = obj as BitArray64;
            if (objAsNum == null)
            {
                return false;
            }
            return this.bitvalue == objAsNum.bitvalue;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.bitvalue.GetHashCode();
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !(first.Equals(second));
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int i = MaxArrayCapacity - 1; i >= 0; i--)
            {
                result.Append(this[i]);
                if (i != 0)
                {
                    result.Append(", ");
                }
                else
                {
                    continue;
                }
            }
            return result.ToString();
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
            return GetEnumerator();
        }
    }
}

