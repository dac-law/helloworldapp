using System;
using System.Collections.Generic;
using System.Text;

namespace HexQFormat.Models
{
    interface IConverter
    {
        String toHex();

        String toBinary();

        int toDecimal();
    }

    public enum Format
    {
        // value is number of bytes
        BYTE = 1,
        WORD = 2,
        DWORD = 4,
        QWORD = 8
    }

    public enum Signing
    {
        UNSIGNED,
        SIGNED
    }

    public enum ResultFormat
    {
        HEX,
        DEC,
        OCT,
        BIN
    }
}
