using System.Net.NetworkInformation;

namespace Task2;

static class GeometricCalculate
{   
    const double _pi=3.14;
    static double Radius;
    
    public static double CalcCircleArea(double radius)
    {
        return _pi*radius*radius;
    }
    public static double CalcCirclePerimeter(double radius)
    {
        return 2 * _pi * radius;
    }


    // RectangleArea

    static double Length;
    static double Width;

    public static double CalcRectangleArea(double length,double width )
    {
        return length * width;
    }

     public static double CalcRectanglePerimeter(double length,double width )
    {
        return 2 * (length + width);
    }

    //Trieangle


    static double b;
    static double h;

    static double c;

    public static double CalcTriangleArea( double bas , double height)
    {
        return 0.5 * bas * height;
    }

    public static double CalcTrianglePerimeter(double side1, double side2,double side3)
    {
        return side1 + side2 + side3;
    }

}
