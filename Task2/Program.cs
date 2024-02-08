
using Task2;
System.Console.Write("Enter your number : ");
var circArea = GeometricCalculate.CalcCircleArea(Convert.ToInt32(System.Console.ReadLine()));
System.Console.WriteLine($"Circle Area: {circArea}");
System.Console.Write("Enter your number : ");

var circPerimeter = GeometricCalculate.CalcCirclePerimeter(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine($"Circle Perimeter: {circPerimeter}");
System.Console.Write("Enter your number 2 time  : ");

var recArea = GeometricCalculate.CalcRectangleArea(Convert.ToInt32(Console.ReadLine()) , Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine($"Rectangle Area: {recArea}");
System.Console.Write("Enter your number 2 time : ");
var recPerimeter = GeometricCalculate.CalcRectanglePerimeter(Convert.ToInt32(Console.ReadLine()) , Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine($"Rectangle Perimeter: {recPerimeter}");
System.Console.Write("Enter your number 2 time : ");
var trigArea = GeometricCalculate.CalcTriangleArea(Convert.ToInt32(Console.ReadLine()) ,Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine($"Triangle Area: {trigArea}");
System.Console.Write("Enter your number 3 time : ");
var trigPerimetr = GeometricCalculate.CalcTrianglePerimeter(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine($"Triangle Perimeter: {trigPerimetr}");