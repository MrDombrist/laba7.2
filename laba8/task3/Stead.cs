class Stead : Holding,INalog
{
    public double Area { get; set; }
    public Stead() { }
    public Stead(double area)
    {
        Area = area;
    }
    public Stead(Stead stead)
    {
        Area=stead.Area;
    }
    public double Nalog() { return Cost * 0.3 / 100; }
    public override void Output() { Console.Write("Земельный участок площаью: "+ Area + " " + Cost) ; }
}