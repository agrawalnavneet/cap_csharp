using System;

interface IArea{
    double GetArea();
}

abstract class Shape : IArea{
    public abstract double GetArea();
}
class Circle : Shape{
    double r;
        public Circle(double r){
        this.r = r;}
    public override double GetArea(){
        return Math.PI * r * r;}}

class Rectangle : Shape{
    double w, h;
        public Rectangle(double w, double h)
    {
        this.w = w;
        this.h = h;}
    public override double GetArea(){
        return w * h;
    }
}

class Triangle : Shape{
    double b, h;
    public Triangle(double b, double h){
        this.b = b;
        this.h = h;
    }

    public override double GetArea()
    {
        return 0.5 * b * h;
    }
}

class Stri{
   public  static void stri(){
        string[] shapes ={
            "C 3",
            "R 4 5",
            "T 6 2"};
        double totalArea = 0;
        foreach (string s in shapes)
        {
            string[] p = s.Split(' ');
            Shape shape = null;

            if (p[0] == "C")
                shape = new Circle(double.Parse(p[1]));
            else if (p[0] == "R")
                shape = new Rectangle(double.Parse(p[1]), double.Parse(p[2]));
            else if (p[0] == "T")
                shape = new Triangle(double.Parse(p[1]), double.Parse(p[2]));

            totalArea += shape.GetArea();
        }

        totalArea = Math.Round(totalArea, 2, MidpointRounding.AwayFromZero);
        Console.WriteLine(totalArea);
    }
}
