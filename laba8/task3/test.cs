using System.Security;

class Test
{
    static void Main(string[] args)
    {
        Worker a = new Worker("Иван", "Кукин", new DateTime(1950, 04, 01), 'м', 30000, 25);
        Worker b = new Worker("Людмила", "Кукина", new DateTime(1965, 05, 01), 'ж', 35000, 0);
        Building a1 = new Building("Зайцева, 79");
        a1.Cost = 3000000;
        Stead a2 = new Stead(600);
        a2.Cost = 500000;

        Stead a3 = new Stead(1000);
        a3.Cost = 300000;
        Horse a4 = new Horse(7, 250);
        a4.Cost = 20000;
        a4.Name = "Ромашка";
        Car a5 = new Car(27);
        a5.Cost = 10000;
        a5.Name = "ЗАЗ-965";
        SmallShip a6 = new SmallShip(0, 15);
        a6.Cost = 25000;


        Building b1 = new Building();
        b1 = a1;
        Stead b2 = new Stead();
        b2 = a2;
        Worker[] fam = new Worker[2];
        fam[0] = a;
        fam[1] = b;
        Holding[] family = new Holding[6];
        family[0] = a1;
        family[1] = a2;
        family[2] = a3;
        family[3] = a4;
        family[4] = a5;
        family[5] = a6;
        Console.WriteLine("Всё имущество у этой семьи стоит: " + AllCost(family));
        INalog[] nalog = new INalog[7];
        nalog[0] = a;
        nalog[1] = b;
        nalog[2] = a1;
        nalog[3] = a2;
        nalog[4] = a3;
        nalog[5] = a5;
        nalog[6] = a6;
        Console.Write("Общий налог: "+ Nal(nalog));
        Console.WriteLine();
        Array.Sort(family);Console.WriteLine("Отсортированный массив данных: ");
        for(int i = 0; i < family.Length; i++)
        {
            family[i].Output(); Console.Write("\t");
        }
    }
    public static double AllCost(Holding[] fam)
    {
        double cost = 0;
        foreach (Holding h in fam)
        {
            cost += h.Cost;
        }
        return cost;
    }
    public static double Nal(INalog[] nalog)
    {
        double nal = 0;
        foreach(var fl in nalog)
        {
            nal += fl.Nalog();
        }
        return nal;
    }
}