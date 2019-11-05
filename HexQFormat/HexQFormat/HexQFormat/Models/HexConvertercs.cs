using System;
using System.Collections.Generic;
using System.Text;

namespace HexQFormat.Models
{
    public class HexConvertercs : IConverter
    {
        public int Value { get; set; }

        public HexConvertercs(int value)
        {
            this.Value = value;
        }

        public ulong ToInteger(String hexValue, Format format)
        {
            return ulong.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
        }

        public String toHexString()
        {
            return Value.ToString("X");
        }

        public int getTwosComp()
        {
            int invertedVal = Value;
            return ~invertedVal + 1;
        }

    }



}
