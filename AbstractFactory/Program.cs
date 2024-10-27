//Абстрактная фабрика
public abstract class CarsFactory
{
    public abstract Sedan CreateSedan();
    public abstract Сrossover CreateCrossover();
}
public class Sedan{}
public class Сrossover{}

//Конкретные фабрики
public class LadaFactory : CarsFactory
{
    public override Sedan CreateSedan()
    {
        return new LadaSedan();
    }

    public override Сrossover CreateCrossover()
    {
        return new LadaCrossover();
    }
}

public class SolarisFactory : CarsFactory
{
    public override Sedan CreateSedan()
    {
        return new SolarisSedan();
    }

    public override Сrossover CreateCrossover()
    {
        return new SolarisCrossover();
    }
}

//классы, представляющие реализацию абстрактных классов
public class LadaSedan : Sedan
{
    public LadaSedan()
    {
        Console.WriteLine("Создан седан - марки Lada");
    }
}
public class LadaCrossover : Сrossover
{
    public LadaCrossover()
    {
        Console.WriteLine("Создан Кроссовер - марки Lada");
    }
}

public class SolarisSedan : Sedan
{
    public SolarisSedan()
    {
        Console.WriteLine("Создан седан - марки Solaris");
    }
}

public class SolarisCrossover : Сrossover
{
    public SolarisCrossover()
    {
        Console.WriteLine("Создан Кроссовер - марки Solaris");
    }
}

class Program
{
    private Sedan sedan;
    private Сrossover crossover;

    public Program(CarsFactory carsFactory)
    {
        sedan = carsFactory.CreateSedan();
        crossover = carsFactory.CreateCrossover();
    }
    static void Main(string[] args) {}
}

