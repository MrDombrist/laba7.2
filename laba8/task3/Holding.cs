abstract class Holding: IComparable
{
    public Person Owner { get; set; }   
    public int Cost { get; set; }
    abstract public void Output();
    public int CompareTo(object obj) 
    {
        Holding holding = obj as Holding;
        if (holding.Cost != null) 
        { if (this.Cost> holding.Cost)
                return 1;
          if (this.Cost < holding.Cost)
                return -1;
          else 
                return 0; 
        }
        else
            return 1;
    }
}