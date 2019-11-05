using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HexQFormat.Models;

namespace HexQFormatTest
{
    [TestClass]
    public class ByteFormatTest
    {
        [TestMethod]
        public void TestByteUnsignedRange()
        {
            ByteFormat bFormat = new ByteFormat();
            int expectedUMax = bFormat.GetUMax();
            int expectedUMin = bFormat.GetUMin();

            Assert.AreEqual(expectedUMax, 255);
            Assert.AreEqual(expectedUMin, 0);
        }

        [TestMethod]
        public void TestByteSignedRange()
        {
            ByteFormat bFormat = new ByteFormat();
            int expectedMax = bFormat.GetSMax();
            int expectedMin = bFormat.GetSMin();

            Assert.AreEqual(expectedMax, 127);
            Assert.AreEqual(expectedMin, -128);
        }
    }
}
