﻿//using System.Runtime.Intrinsics.X86;
using TriangleSolver;

namespace bharatkumar_A2.nunitTests;

public class Tests
{
    private Triangle triangleSolver { get; set; } = null!;

    [SetUp]
    public void Setup()
    {
        triangleSolver = new Triangle();
    }


    //test1

    [Test]
    public void AnalyzeTriangle_Outputvalid_ISOSCELESTriangle1()
    {
        //Arrange

        int side_1 = 10;
        int side_2 = 10;
        int side_3 = 18;

        string expected = "The triangle is valid and is an ISOSCELES";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test2

    [Test]
    public void AnalyzeTriangle_Outputvalid_EQUILATERALTriangle1()
    {
        //Arrange

        int side_1 = 5;
        int side_2 = 5;
        int side_3 = 5;

        string expected = "The triangle is valid and is an EQUILATERAL";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test3

    [Test]
    public void AnalyzeTriangle_Outputvalid_ISOSCELESTriangle2()
    {
        //Arrange

        int side_1 = 2;
        int side_2 = 3;
        int side_3 = 2;

        string expected = "The triangle is valid and is an ISOSCELES";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test4

    [Test]
    public void AnalyzeTriangle_Outputvalid_SCALENETriangle1()
    {
        //Arrange

        int side_1 = 5;
        int side_2 = 8;
        int side_3 = 9;

        string expected = "The triangle is valid and is a SCALENE";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test5

    [Test]
    public void AnalyzeTriangle_Outputvalid_SCALENETriangle2()
    {
        //Arrange

        int side_1 = 23;
        int side_2 = 20;
        int side_3 = 27;

        string expected = "The triangle is valid and is a SCALENE";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test6

    [Test]
    public void AnalyzeTriangle_Outputvalid_SCALENETriangle3()
    {
        //Arrange

        int side_1 = 23;
        int side_2 = 40;
        int side_3 = 20;

        string expected = "The triangle is valid and is a SCALENE";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test7

    [Test]
    public void AnalyzeTriangle_OutputValid_ScaleneTriangle4()
    { 
        //Arrange

        int side_1 = 15;
        int side_2 = 13;
        int side_3 = 8;

        string expected = "The triangle is valid and is a SCALENE";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test8

    [Test]

    public void AnalyzeTriangle_OutputValid_IsoscelesTriangle3()
    {
        // Arrange

        int side_1 = 6;
        int side_2 = 5;
        int side_3 = 5;

        string expected = "The triangle is valid and is an ISOSCELES";

        // Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        // Assert

        Assert.AreEqual(expected, actual);
    }

    //test9

    [Test]
    public void AnalyzeTriangle_Outputvalid_SCALENETriangle5()
    {
        //Arrange

        int side_1 = 6;
        int side_2 = 8;
        int side_3 = 12;

        string expected = "The triangle is valid and is a SCALENE";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test10

    [Test]
    public void AnalyzeTriangle_Outputvalid_InvalidOutput1()
    {
        //Arrange

        int side_1 = 0;
        int side_2 = 2;
        int side_3 = 2;

        string expected = "At least one side of your triangle has a zero length and is thus invalid";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test11

    [Test]

    public void AnalyzeTriangle_InvalidOutput2()
    {
        //Arrange

        int side_1 = 20;
        int side_2 = 0;
        int side_3 = 20;

        string expected = "At least one side of your triangle has a zero length and is thus invalid";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test12

    [Test]

    public void AnalyzeTriangle_InvalidOutput3()
    {
        //Arrange

        int side_1 = 10;
        int side_2 = 20;
        int side_3 = 0;

        string expected = "At least one side of your triangle has a zero length and is thus invalid";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test13

    [Test]

    public void AnalyzeTriangle_InvalidNumbers1()
    {
        //Arrange

        int side_1 = 12;
        int side_2 = -14;
        int side_3 = -12;

        string expected = "A triangle cannot be formed with those numbers";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test14

    [Test]

    public void AnalyzeTriangle_InvalidNumber2()
    {
        //Arrange

        int side_1 = -20;
        int side_2 = 20;
        int side_3 = -21;

        string expected = "A triangle cannot be formed with those numbers";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test15

    [Test]

    public void AnalyzeTriangle_InvalidNumber3()
    {
        //Arrange

        int side_1 = 21;
        int side_2 = -12;
        int side_3 = 22;

        string expected = "A triangle cannot be formed with those numbers";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }
}
