using NUnit.Framework;
using System.Collections.Generic;
using TriangleTesting;


namespace TestProj
{
    public class Tests
    {
        [Test]
        public void ScaleneInt() 
        {

            var expect = ("разносторонний", new List<(int, int)> { (0, 0), (39, 0), (33, 47) });

            var actual = Triangle.GetTriangleInfo("48", "58", "39");

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void EquilateralInt() 
        {
            var expect = ("равносторонний", new List<(int, int)> { (0, 0), (5, 0), (2, 4) });

            var actual = Triangle.GetTriangleInfo("5", "5", "5");

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void IsoscelesInt() 
        {
            var expect = ("равнобедренный", new List<(int, int)> { (0, 0), (2, 0), (1, 4) });

            var actual = Triangle.GetTriangleInfo("5", "5", "2");

            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void IsoscelesInt1() 
        {
            var expect = ("равнобедренный", new List<(int, int)> { (0, 0), (5, 0), (4, 1) });

            var actual = Triangle.GetTriangleInfo("2", "5", "5");

            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void IsoscelesInt2() 
        {
            var expect = ("равнобедренный", new List<(int, int)> { (0, 0), (5, 0), (0, 1) });

            var actual = Triangle.GetTriangleInfo("5", "2", "5");

            Assert.AreEqual(expect, actual);
        }

        [TestCase("5", "5", "10")]
        [TestCase("2,5", "5", "7,5")]
        public void TriangleInequality(string a, string b, string c) 
        {
            var expect = ("не треугольник", new List<(int, int)> { (-1, -1), (-1, -1), (-1, -1) });

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.AreEqual(expect, actual);
        }


        [TestCase("5а", "5", "10")]
        [TestCase("а", "b", "c")]
        [TestCase("6", "8", "1c")]
        public void NotANumber(string a, string b, string c) 
        {
            var expect = ("", new List<(int, int)> { (-2, -2), (-2, -2), (-2, -2) });

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ScaleneFloat() 
        {

            var expect = ("разносторонний", new List<(int, int)> { (0, 0), (3, 0), (3, 4) });

            var actual = Triangle.GetTriangleInfo("4,5", "5,8", "3,9");

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void EquilateralFloat() 
        {
            var expect = ("равносторонний", new List<(int, int)> { (0, 0), (4, 0), (2, 3) });

            var actual = Triangle.GetTriangleInfo("4,5", "4,5", "4,5");

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void IsoscelesFloat()
        {
            var expect = ("равнобедренный", new List<(int, int)> { (0, 0), (2, 0), (1, 12) });

            var actual = Triangle.GetTriangleInfo("12,5", "12,5", "2,5");

            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void IsoscelesFloat1() 
        {
            var expect = ("равнобедренный", new List<(int, int)> { (0, 0), (12, 0), (0, 2) });

            var actual = Triangle.GetTriangleInfo("12,5", "2,5", "12,5");

            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void IsoscelesFloat2() 
        {
            var expect = ("равнобедренный", new List<(int, int)> { (0, 0), (12, 0), (12, 2) });

            var actual = Triangle.GetTriangleInfo("2,5", "12,5", "12,5");

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ScaleneScale() 
        {

            var expect = ("разносторонний", new List<(int, int)> { (0, 0), (76, 0), (100, 100) });

            var actual = Triangle.GetTriangleInfo("405", "508", "309");

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void EquilateralScale() 
        {
            var expect = ("равносторонний", new List<(int, int)> { (0, 0), (100, 0), (86, 86) });

            var actual = Triangle.GetTriangleInfo("405", "405", "405");

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void IsoscelesScale() 
        {
            var expect = ("равнобедренный", new List<(int, int)> { (0, 0), (92, 0), (100, 100) });

            var actual = Triangle.GetTriangleInfo("125", "125", "105");

            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void IsoscelesScale1() 
        {
            var expect = ("равнобедренный", new List<(int, int)> { (0, 0), (100, 0), (76, 76) });

            var actual = Triangle.GetTriangleInfo("105", "125", "125");

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ScaleneFloatScale() 
        {
            var expect = ("разносторонний", new List<(int, int)> { (0, 0), (48, 0), (15, 15) });

            var actual = Triangle.GetTriangleInfo("122,5", "232,5", "112,5");

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void IsoscelesScale2() 
        {
            var expect = ("равносторонний", new List<(int, int)> { (0, 0), (100, 0), (91, 91) });

            var actual = Triangle.GetTriangleInfo("122,5", "112,5", "112,5");

            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void IsoscelesScale3()
        {
            var expect = ("равносторонний", new List<(int, int)> { (0, 0), (52, 0), (100, 100) });

            var actual = Triangle.GetTriangleInfo("222,5", "222,5", "112,5");

            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void IsoscelesScale4() 
        {
            var expect = ("равносторонний", new List<(int, int)> { (0, 0), (100, 0), (52, 52) });

            var actual = Triangle.GetTriangleInfo("122,5", "222,5", "222,5");

            Assert.AreEqual(expect, actual);
        }
    }
}