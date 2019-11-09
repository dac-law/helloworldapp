using System;
using System.Collections.Generic;
using System.Text;

namespace HexQFormat.Models
{
    class FormatFactory
    {

        public static AbstractBitFormat GetFormat(Format format, Signing signing)
        {
            if (format.Equals(Format.BYTE))
            {
                // return a signed or unsigned byte
                return new ByteFormat();
            }
            else
            {
                return null;
            }


        }

    }
}
