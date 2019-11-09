using System;
using System.Collections.Generic;
using System.Text;

namespace HexQFormat.Models
{
    public class ByteFormat : AbstractBitFormat
    {
        public ByteFormat()
        {
            this.NUM_BYTES = (int) Format.BYTE;
        }

        public override int GetTwosComp()
        {
            throw new NotImplementedException();
        }

        public override int GetUMax()
        {
            return byte.MaxValue;
        }

        public override int GetUMin()
        {
            return byte.MinValue;
        }

        public override int GetSMax()
        {
            return sbyte.MaxValue;
        }

        public override int GetSMin()
        {
            return sbyte.MinValue;
        }

        
    }

    
}
