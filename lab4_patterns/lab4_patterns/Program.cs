using System;

// Абстрактні продукти
public interface ICPU
{
    void Compute();
}

public interface ICooler
{
    void Cool();
}

// Конкретні продукти
public class HighPerformanceCPU : ICPU
{
    public void Compute()
    {
        Console.WriteLine("High performance CPU is computing...");
    }
}

public class EnergyEfficientCPU : ICPU
{
    public void Compute()
    {
        Console.WriteLine("Energy efficient CPU is computing...");
    }
}

public class AirCooler : ICooler
{
    public void Cool()
    {
        Console.WriteLine("Air cooler is cooling...");
    }
}

public class WaterCooler : ICooler
{
    public void Cool()
    {
        Console.WriteLine("Water cooler is cooling...");
    }
}

// Абстрактна фабрика
public interface IComputerFactory
{
    ICPU CreateCPU();
    ICooler CreateCooler();
}

// Конкретні фабрики
public class HighPerformanceFactory : IComputerFactory
{
    public ICPU CreateCPU()
    {
        return new HighPerformanceCPU();
    }

    public ICooler CreateCooler()
    {
        return new WaterCooler();
    }
}

public class EnergyEfficientFactory : IComputerFactory
{
    public ICPU CreateCPU()
    {
        return new EnergyEfficientCPU();
    }

    public ICooler CreateCooler()
    {
        return new AirCooler();
    }
}

// Клієнтський код
public class Computer
{
    private readonly ICPU _cpu;
    private readonly ICooler _cooler;

    public Computer(IComputerFactory factory)
    {
        _cpu = factory.CreateCPU();
        _cooler = factory.CreateCooler();
    }

    public void Assemble()
    {
        _cpu.Compute();
        _cooler.Cool();
    }
}

// Тестування
public class Program
{
    public static void Main()
    {
        // Вибір високопродуктивної конфігурації
        IComputerFactory highPerformanceFactory = new HighPerformanceFactory();
        Computer highPerformanceComputer = new Computer(highPerformanceFactory);
        Console.WriteLine("High Performance Computer:");
        highPerformanceComputer.Assemble();

        // Вибір енергоефективної конфігурації
        IComputerFactory energyEfficientFactory = new EnergyEfficientFactory();
        Computer energyEfficientComputer = new Computer(energyEfficientFactory);
        Console.WriteLine("\nEnergy Efficient Computer:");
        energyEfficientComputer.Assemble();
    }
}
