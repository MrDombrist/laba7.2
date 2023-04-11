class STP:Cilinder,ICLIable
{
    public STP(Point2D a, Point2D b, double h,Point2D c):base(a,b,h) { third = c; }
    public STP():base(){ third = new Point2D(0, 0); }
    public STP(Point2D a,Point2D b,Point2D c)
    {
        Center = a;
        Anydot = b;
        third = c;
    }

    protected double AreaT()
    {
        double p = (Center.Distance00(Anydot) + Center.Distance00(third) + third.Distance00(Anydot)) / 2;
        return Math.Sqrt(p*(p-Center.Distance00(Anydot))*(p-Center.Distance00(third))*(p-third.Distance00(Anydot)));
    }
    public override double Area()
    {
        return AreaT();
    }
    public override double Lenght()
    {
        return Center.Distance00(Anydot) + Center.Distance00(third) + third.Distance00(Anydot);
    }
    public override void Input1()
    {
        Console.WriteLine("Введите первую точку: ");
        Center.Input1();
        Console.WriteLine("Введите вторую точку: ");
        Anydot.Input1();
        Console.WriteLine("Введите третью точку: ");
        third.Input1();
        Console.WriteLine("Введите высоту призмы: ");
        Height = Convert.ToDouble(Console.ReadLine());
    }
    public override void Output1()
    {
        Console.Write("Координаты первой точки: "); Center.Output1();
        Console.Write("Координаты второй точки: "); Anydot.Output1();
        Console.Write("Координаты третьей точки: "); third.Output1();    
        Console.WriteLine("Высота призмы: " + Height);
    }

    public void set_third(Point2D c) { third = c; }
    public Point2D get_third() { return third; }
    protected Point2D third;

}