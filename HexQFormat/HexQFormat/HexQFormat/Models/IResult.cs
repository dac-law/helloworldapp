﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HexQFormat.Models
{
    /*
    public static string convert(double value, int _base)
    {
        // https://social.msdn.microsoft.com/Forums/vstudio/en-US/0ff76c9a-8d8c-46f3-94cc-420f719a14e4/how-to-convert-floatdoubleulong-into-binaryotcalhex-string?forum=netfxbcl
        string s = String.Empty;

        // value is the value you want to convert to a string (double, long, int, ...)

        foreach (byte b in BitConverter.GetBytes(value))
        {
            s += Convert.ToString(b, _base).PadLeft(2, '0'); // for hex. For binary, use 2 and 8. For octal, use 8 and 3
        }
        return s;
    }
    */

    public abstract class Observer
    {
        public abstract void Update();
    }

    public abstract class Subject
    {
        protected List<Observer> observers = new List<Observer>();

        protected void Register(Observer observer)
        {
            observers.Add(observer);
        }

        protected void UnRegister(Observer observer)
        {
            observers.Remove(observer);
        }

        public abstract void Notify();
    }

    // Concrete Subject : Used to notify obsevers when there is a change of state
    public class CalculatorResult : Subject
    {
        // https://github.com/GeorgDangl/Dangl.Calculator/blob/dev/src
        public bool IsValid { get; internal set; }

        private double result;

        public double Result
        {
            get { return result; }
            set {
                result = value;
            }
        }

        public override void Notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }



    }

    public interface IResult
    {
        //string Name { get; }
        string GetFormatted(double rawValue);
    }

    class IntResult : IResult
    {
        public string GetFormatted(double rawValue)
        {
            return rawValue.ToString();
        }
    }

    class HexResult : IResult
    {

        public string GetFormatted(double rawValue)
        {
            return BitConverter.DoubleToInt64Bits(rawValue).ToString("X");
        }
    }
    /*
    class BinaryResult : IResult
    {

        public string GetFormatted(int rawValue)
        {
            return BitConverter.ToString(rawValue, 2);
        }
    }

    class OctalResult : IResult
    {
        public string GetFormatted(int rawValue)
        {
            return Convert.ToString(rawValue, 8);
        }
    }
    */
}
