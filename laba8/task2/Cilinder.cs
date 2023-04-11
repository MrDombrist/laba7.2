class Cilinder : ICLIable
{ 
    public Cilinder() 
    { 
        
        Center=new Point2D(0,0);
        Anydot = new Point2D(0,0);
        Height = 0;
    }
    public Cilinder(Point2D a,Point2D b, double h) 
    {
        Center = a;
        Anydot = b;
        Height = h; 
    }


    public Point2D get_c() { return Center; }
    public Point2D get_any() { return Anydot; }
    public double get_h() { return Height; }
    public void set_h(double h) { Height = h; }
    public void set_any(Point2D point2D) { Anydot = point2D; }
    public void set_c(Point2D poin2D) { Center = poin2D; }



    virtual public void Input1()
    {
        Console.WriteLine("Введите центр окружности: ");
        Center.Input1();
        Console.WriteLine("Введите любую точку на окружности: ");
        Anydot.Input1();
        Console.WriteLine("Введите высоту цилиндра: ");
        Height = Convert.ToDouble(Console.ReadLine());
    }
    virtual public void Output1()
    {
        Console.Write("Координаты центра: "); Center.Output1();
        Console.Write("Координаты точки на окружности: "); Anydot.Output1();
        Console.WriteLine("Высота цилиндра: "+ Height);
    }
    virtual public double Area()
    {
        return Math.PI * Math.Pow(Center.Distance00(Anydot), 2);
    }
    virtual public double Lenght()
    {
        return 2*Math.PI*Center.Distance00(Anydot);
    }
    public double Volume()
    {
        return Area() * Height;
    }
    public double SideArea()
    {
        return Height * Lenght();
    }

    protected Point2D Center;
    protected Point2D Anydot;
    protected double Height;

}
