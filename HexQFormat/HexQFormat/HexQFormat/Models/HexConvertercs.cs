using System;
using System.Collections.Generic;
using System.Text;

namespace HexQFormat.Models
{

    // https://riptutorial.com/csharp/example/9365/convert-decimal-number-to-binary-octal-and-hexadecimal-format
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

        public int getTwosComp()
        {
            int invertedVal = Value;
            return ~invertedVal + 1;
        }

        public String toHexString(dynamic value)
        {
            return Convert.ToString(value, 16);  //OUTPUT : f
        }

        public String toHex()
        {
            return "";
        }

        public String toBinary()
        {
            return "";
        }

        public int toDecimal()
        {
            return 1;
        }

    }



}
