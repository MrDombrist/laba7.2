class SmallShip : Transport,INalog
{
    public int Paddle { get; set; } 
    public double Power { get; set; }
    public SmallShip() { }
    public SmallShip(int paddle, double power)
    {
        Paddle = paddle;
        Power = power;
    }   
    public SmallShip(SmallShip smallShip)
    {
        Paddle=smallShip.Paddle;
        Power=smallShip.Power;
    }
    public double Nalog() { return Power * 10; }
    public override void Output() { Console.Write("Лодка "+ Power + " "+ Cost); }
}