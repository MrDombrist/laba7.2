class Car : Transport,INalog
{
    public double Power { get; set; }
    public Car() { }
    public Car(double power)
    {
        Power = power;
    }
    public Car(Car car)
    {
        Power=car.Power;
    }
    public double Nalog() { return 2.5*Power; }
    public override void Output() { Console.Write(Name + " " + Power + " " + Cost); }
}
