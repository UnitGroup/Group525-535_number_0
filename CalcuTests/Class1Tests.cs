using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calcu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcu.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void calculateTest_znach1_Add()
        {
            string per = "3";
            double a = 5;
            int znach = 1;
            double expected = 8;
            double rez = double.Parse(Class1.calculate(per, a, znach));
            Assert.AreEqual(expected, rez);
        }
        [TestMethod()]
        public void calculateTest_znach2_Sub()
        {
            string per = "3";
            double a = 5;
            int znach = 2;
            double expected = 2;
            double rez = double.Parse(Class1.calculate(per, a, znach));
            Assert.AreEqual(expected, rez);
        }
        [TestMethod()]
        public void calculateTest_znach3_Mult()
        {
            string per = "3";
            double a = 5;
            int znach = 3;
            double expected = 15;
            double rez = double.Parse(Class1.calculate(per, a, znach));
            Assert.AreEqual(expected, rez);
        }
        [TestMethod()]
        public void calculateTest_znach4_Div()
        {
            string per = "3";
            double a = 12;
            int znach = 4;
            double expected = 4;
            double rez = double.Parse(Class1.calculate(per, a, znach));
            Assert.AreEqual(expected, rez);
        }
        [TestMethod()]
        public void calculateTest_znach5_Sqrt()
        {
            string per = "0";
            double a = 64;
            int znach = 5;
            double expected = 8;
            double rez = double.Parse(Class1.calculate(per, a, znach));
            Assert.AreEqual(expected, rez);
        }
        [TestMethod()]
        public void calculateTest_znach6_Sin_a()
        {
            string per = "0";
            double a = 45;
            int znach = 6;
            double expected = 0.9;
            double rez = double.Parse(Class1.calculate(per, a, znach));
            Assert.AreEqual(expected, rez);
        }
        [TestMethod()]
        public void calculateTest_znach7_Factorial()
        {
            string per = "0";
            double a = 6;
            int znach = 7;
            double expected = 720;
            double rez = double.Parse(Class1.calculate(per, a, znach));
            Assert.AreEqual(expected, rez);
        }
    }
}