class Building : Holding,INalog
{
    public string Address { get; set; }
    public Building() { }
    public Building(string address)
    {
        Address = address;
    }
    public Building(Building building)
    {
        Address=building.Address;
    }
    public double Nalog() { return Cost * 1.5 / 100; }
    public override void Output() { Console.Write("Квартира по адресу: "+Address+ " "+ Cost); }
}