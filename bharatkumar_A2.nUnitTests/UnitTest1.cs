//using System.Runtime.Intrinsics.X86;
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
    public void AnalyzeTriangle_Input20and20and20_OutputvalidEquilateralTriangle()
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
    public void AnalyzeTriangle_Input20and20and20_OutputvalidEquilateralTriangle()
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
    public void AnalyzeTriangle_Input20and20and20_OutputvalidEquilateralTriangle()
    {
        //Arrange

        int side_1 = 2;
        int side_2 = 2;
        int side_3 = 4;

        string expected = "The triangle is valid and is an ISOSCELES";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test4

    [Test]
    public void AnalyzeTriangle_Input20and20and20_OutputvalidEquilateralTriangle()
    {
        //Arrange

        int side_1 = 5;
        int side_2 = 8;
        int side_3 = 9;

        string expected = "The triangle is valid and is an SCALENE";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test5

    [Test]
    public void AnalyzeTriangle_Input20and20and20_OutputvalidEquilateralTriangle()
    {
        //Arrange

        int side_1 = 23;
        int side_2 = 20;
        int side_3 = 27;

        string expected = "The triangle is valid and is an SCALENE";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test6

    [Test]
    public void AnalyzeTriangle_Input20and20and20_OutputvalidEquilateralTriangle()
    {
        //Arrange

        int side_1 = 23;
        int side_2 = 40;
        int side_3 = 20;

        string expected = "The triangle is valid and is an SCALENE";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test6

    [Test]
    public void AnalyzeTriangle_Input20and20and20_OutputvalidEquilateralTriangle()
    {
        //Arrange

        int side_1 = 15;
        int side_2 = 13;
        int side_3 = 8;

        string expected = "The triangle is valid and is an SCALENE";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    //test7

    [Test]
    public void AnalyzeTriangle_Input20and20and20_OutputvalidEquilateralTriangle()
    {
        //Arrange

        int side_1 = 10;
        int side_2 = 10;
        int side_3 = 20;

        string expected = "The triangle is valid and is an ISOSCELENE";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void AnalyzeTriangle_Input20and20and20_OutputvalidEquilateralTriangle()
    {
        //Arrange

        int side_1 = 20;
        int side_2 = 20;
        int side_3 = 20;

        string expected = "The triangle is valid and is an EQUILATERAL";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void AnalyzeTriangle_Input20and20and20_OutputvalidEquilateralTriangle()
    {
        //Arrange

        int side_1 = 20;
        int side_2 = 20;
        int side_3 = 20;

        string expected = "The triangle is valid and is an EQUILATERAL";

        //Act

        string actual = Triangle.AnalyzeTriangle(side_1, side_2, side_3);

        //Assert

        Assert.AreEqual(expected, actual);
    }
}