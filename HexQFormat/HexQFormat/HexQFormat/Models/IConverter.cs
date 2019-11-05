using System;
using System.Collections.Generic;
using System.Text;

namespace HexQFormat.Models
{
    interface IConverter
    {
        

    }

    public enum Format
    {
        // value is number of bytes
        BYTE = 1,
        WORD = 2,
        DWORD = 4,
        QWORD = 8
    }
}
