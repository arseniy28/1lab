using System;

abstract class Solid
{
    public abstract double Volume();
    public abstract double SurfaceArea();
}

class Cube : Solid
{
    public double sideLength;

    public Cube(double sideLength)
    {
        this.sideLength = sideLength;
    }

    public override double Volume()
    {
        return Math.Pow(sideLength, 3);
    }

    public override double SurfaceArea()
    {
        return 6 * Math.Pow(sideLength, 2);
    }
}

class Cylinder : Solid
{
    public double radius;
    public double height;

    public Cylinder(double radius, double height)
    {
        this.radius = radius;
        this.height = height;
    }

    public override double Volume()
    {
        return Math.PI * Math.Pow(radius, 2) * height;
    }

    public override double SurfaceArea()
    {
        return 2 * Math.PI * radius * (radius + height);
    }
}

class Program
{
    static void PrintSolidInfo(Solid solid)
    {
        string solidType = solid.GetType().Name;
        string solidParams = "";
        if (solidType == "Cube")
        {
            Cube cube = (Cube)solid;
            solidParams = $"Side length: {cube.sideLength}";
        }
        else if (solidType == "Cylinder")
        {
            Cylinder cylinder = (Cylinder)solid;
            solidParams = $"Radius: {cylinder.radius}, Height: {cylinder.height}";
        }
        Console.WriteLine($"{solidType} ({solidParams}) - Volume: {solid.Volume()}, Surface Area: {solid.SurfaceArea()}");
    }

    static void Main(string[] args)
    {
        Cube cube = new Cube(5);
        Cylinder cylinder = new Cylinder(3, 7);

        PrintSolidInfo(cube);
        PrintSolidInfo(cylinder);

        Console.ReadLine();
    }
}