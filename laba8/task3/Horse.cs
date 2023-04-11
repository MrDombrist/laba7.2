class Horse : Transport
{
    public int Age { get; set; }
    public double Weight { get; set; }
    public Horse() {}
    public Horse(int age, double weight)
    {
        Age = age;
        Weight = weight;
    }
    public Horse(Horse horse)
    {
        Age = horse.Age;
        Weight = horse.Weight;
    }
    public override void Output() { Console.Write(Name + ",  Возраст и вес: " + Age+" "+Weight+ "  "+ Cost); }
}