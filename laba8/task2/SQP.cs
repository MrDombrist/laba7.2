
class SQP : STP,ICLIable
{
    public SQP():base() { Fourth = new Point2D(0, 0); }
    public SQP(Point2D a, Point2D b, double h, Point2D c,Point2D d) : base(a, b, h, c) { Fourth = d; }

    public override void Input1()
    {
        Console.WriteLine("Введите первую точку: ");
        Center.Input1();
        Console.WriteLine("Введите вторую точку: ");
        Anydot.Input1();
        Console.WriteLine("Введите третью точку: ");
        third.Input1();
        Console.WriteLine("Введите четвертую точку: ");
        Fourth.Input1();
        Console.WriteLine("Введите высоту призмы: ");
        Height = Convert.ToDouble(Console.ReadLine());
    }
    public override void Output1()
    {
        Console.Write("Координаты первой точки: "); Center.Output1();
        Console.Write("Координаты второй точки: "); Anydot.Output1();
        Console.Write("Координаты третьей точки: "); third.Output1();
        Console.Write("Координаты четвертой точки: ");Fourth.Output1();
        Console.WriteLine("Высота призмы: " + Height);
    }
    public override double Area()
    {
        STP p = new STP(Center,Anydot,third);
        STP r = new STP(Anydot, third, Fourth);
        return p.Area()+r.Area();
    }
    public override double Lenght()
    {
        return Center.Distance00(Anydot) + Center.Distance00(third) + Fourth.Distance00(Anydot)+ Fourth.Distance00(third);
    }
    public bool Paral()
    {
        if (Center.Distance00(Anydot) == third.Distance00(Fourth) && Center.Distance00(third) == Anydot.Distance00(Fourth))
        {
            if (Math.Abs((Center.get_k(Anydot) - third.get_k(Fourth)) / (1 + Center.get_k(Anydot) * third.get_k(Fourth))) == 0)
            {
                if (Math.Abs((Center.get_k(third) - Anydot.get_k(Fourth)) / (1 + Center.get_k(third) * Anydot.get_k(Fourth)))==0)
                {
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    public bool straight()
    {
        if (Paral())
        {
            if(Center.Distance00(Fourth) == third.Distance00(Anydot)) { return true; }
        }
        return false;
    }
    public bool cube()
    {
        if (straight())
        {
            if(Center.Distance00(Anydot)==Center.Distance00(third) && Center.Distance00(Anydot) == Height)
            {
                return true;
            }
        }
        return false;
    }

    public Point2D get_fourth() { return Fourth;}
    public void set_fourth(Point2D value) { Fourth = value; }
    private Point2D Fourth;
}