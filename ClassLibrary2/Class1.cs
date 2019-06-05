using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApp1;

namespace Classlibrary2
{
    class UnitTest
    {
        [Test]

        void Analyze_Input5and6and7_Returns_ScaleneTriangle()
        {
            //Arraange
            int s1 = 5;
            int s2 = 6;
            int s3 = 7;

            string expectedResult = "Scalene Triangle";


            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

        void Analyze_Input5and5and5_Return_EquilateralTriangle()
        {
            //Arrange
            int s1 = 5;
            int s2 = 5;
            int s3 = 5;

            string expectedResult = "Equilateral Triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]

        void Analyze_Input1and1and7_Returns_DoesnotFormTriangle()
        {
            //Arraange
            int s1 = 1;
            int s2 = 1;
            int s3 = 7;

            string expectedResult = "Doesnot Form Triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }


        [Test]

        void Analyze_Input5and6and7_Returns_IsoscelesTriangle()
        {
            //Arraange
            int s1 = 7;
            int s2 = 8;
            int s3 = 8;

            string expectedResult = "Isosceles Triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }


        [Test]

        void Analyze_Input22and25and21_Returns_ScaleneTriangle()
        {
            //Arraange
            int s1 = 22;
            int s2 = 25;
            int s3 = 21;

            string expectedResult = "Saclene Triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }


        [Test]

        void Analyze_Input33and65and70_Returns_ScaleneTriangle()
        {
            //Arraange
            int s1 = 33;
            int s2 = 65;
            int s3 = 70;

            string expectedResult = "Scalene Triangle";

            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }




        [Test]

        void Analyze_Input9and9and9_Returns_EqualiatralTriangle()
        {
            //Arrange
            int s1 = 9;
            int s2 = 9;
            int s3 = 9;

            string expectedResult = "EqualiatralTriangle";

            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

        void Analyze_Input44and44and50_Returns_IsoscelesTriangle()
        {
            //Arrange
            int s1 = 44;
            int s2 = 44;
            int s3 = 50;


            string expectedResult = "Isosceles  Triangle";
            //Act
            string actualResult = TriangleSolver.Analyze(s1, s2, s3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

    }

}






