using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;
using NUnit.Framework;

namespace Triangletests
{
    [TestFixture]
    public class Assignment2
    {
        string r1 = string.Empty;
        string r2 = string.Empty;

        [Test]

        public void Analyze_input3and3and3_expectedoutputEquilateral()
        {
            //arrange
            int s1 = 3;
            int s2 = 3;
            int s3 = 3;

            //Act
            string r1 = "equilateral";
            string r2 = Trianglesolver.Analyze(s1, s2, s3);


            Assert.AreEqual(r2, r1);
        }
        [Test]

        public void Analyze_input4and3and3_expectedoutputIsosceles()
        {
            //arrange
            int s1 = 4;
            int s2 = 3;
            int s3 = 3;

            //Act
            string r1 = "isosceles";
            string r2 = Trianglesolver.Analyze(s1, s2, s3);


            Assert.AreEqual(r2, r1);
        }
        [Test]

        public void Analyze_input4and3and5_expectedoutputScalene()
        {
            //arrange
            int s1 = 4;
            int s2 = 3;
            int s3 = 5;

            //Act
            string r1 = "scalene";
            string r2 = Trianglesolver.Analyze(s1, s2, s3);


            Assert.AreEqual(r2, r1);
        }
        [Test]

        public void Analyze_input3and3and3_expectedoutputIEquilateral()
        {
            //arrange
            int s1 = 4;
            int s2 = 3;
            int s3 = 3;

            //Act
            string r1 = "isosceles";
            string r2 = Trianglesolver.Analyze(s1, s2, s3);


            Assert.AreEqual(r2, r1);
        }
        [Test]

        public void Analyze_input5and4and4_expectedoutputIsosceles()
        {
            //arrange
            int s1 = 5;
            int s2 = 4;
            int s3 = 4;

            //Act
            string r1 = "isosceles";
            string r2 = Trianglesolver.Analyze(s1, s2, s3);


            Assert.AreEqual(r2, r1);
        }
        [Test]

        public void Analyze_input6and4and3_expectedoutputScalene()
        {
            //arrange
            int s1 = 6;
            int s2 = 4;
            int s3 = 3;

            //Act
            string r1 = "scalene";
            string r2 = Trianglesolver.Analyze(s1, s2, s3);


            Assert.AreEqual(r2, r1);
        }
        [Test]

        public void Analyze_input7and9and51_expectedoutputnotavalidtriangle()
        {
            //arrange
            int s1 = 7;
            int s2 = 9;
            int s3 = 51;

            //Act
            string r1 = "not a valid triangle";
            string r2 = Trianglesolver.Analyze(s1, s2, s3);


            Assert.AreEqual(r2, r1);
        }
        [Test]
        public void Analyze_input8and9and611_expectedoutputnotavalidtriangle()
        {
            //arrange
            int s1 = 8;
            int s2 = 9;
            int s3 = 611;

            //Act
            string r1 = "not a valid triangle";
            string r2 = Trianglesolver.Analyze(s1, s2, s3);


            Assert.AreEqual(r2, r1);
        }
    }

}
    
