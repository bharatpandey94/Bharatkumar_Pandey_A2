using TriangleSolver;

var test = new Triangle();

Console.Write("side 1: ");

var side_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("side 2: ");

var side_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("side 3: ");

var side_3 = Convert.ToInt32(Console.ReadLine());
var answer = Triangle.AnalyzeTriangle(side_1, side_2 , side_3);

Console.WriteLine($"answer : {answer} ");