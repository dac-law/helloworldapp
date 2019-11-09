using System;
using System.Collections.Generic;
using System.Text;

namespace HexQFormat.Models
{
    public abstract class AbstractBitFormat : ITwosComp
    {
        protected int NUM_BYTES;
        private int BITS_IN_BYTE = 8;
        protected int inputValue;

        public AbstractBitFormat()
        {
        }

        public int NumBytes()
        {
            return NUM_BYTES;
        }

        public int NumBits()
        {
            return NUM_BYTES * BITS_IN_BYTE;
        }

        public abstract int GetUMax();

        public abstract int GetUMin();

        public abstract int GetSMax();

        public abstract int GetSMin();

        public abstract int GetTwosComp();
    }
}
