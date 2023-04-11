class Point2D:ICLIable
{
    public double X { get; set; }
    public double Y { get; set; }




    public double Distance00(Point2D a)
    { return Math.Sqrt(Math.Pow(X - a.X, 2) + Math.Pow(Y - a.Y, 2)); }

    public double get_k(Point2D b)
    {
        if (X < b.X && Y < b.Y)
        {
            return (b.Y - X) / (b.X - X);
        }

        else if (X < b.X && Y > b.Y)
        {
            return -(b.Y - Y) / (b.X - X);
        }
        else if (X > b.X && Y > b.Y)
        {
            return (Y - b.Y) / (X - b.X);
        }
        else if (X > b.X && Y < b.Y)
        {
            return -(Y - b.Y) / (X - b.X);
        }
        else { return 0; }
    }

    public Point2D() { }
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }
    public Point2D(Point2D a)
    {
        X = a.X;
        Y = a.Y;
    }



    public void Input1()
    {
        Console.Write("Введите ось Х: ");
        X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите ось Y: ");
        Y = Convert.ToDouble(Console.ReadLine());
    }
    public void Output1()
    {
        Console.WriteLine("x={0} , y={1}", X, Y);
    }
    public override string ToString()
    {
        return "x=" + X + ", y=" + Y;
    }
}
