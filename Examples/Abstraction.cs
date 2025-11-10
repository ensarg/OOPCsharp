namespace OOPExamples.Examples;

/// <summary>
/// Demonstrates Abstraction - hiding complex implementation details and showing
/// only the necessary features using abstract classes and interfaces.
/// </summary>

// Abstract class - cannot be instantiated directly
public abstract class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }

    protected Vehicle(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    // Abstract method - must be implemented by derived classes
    public abstract void Start();
    public abstract void Stop();

    // Concrete method - can be used by all derived classes
    public void DisplayInfo()
    {
        Console.WriteLine($"Vehicle: {Brand} {Model}");
    }
}

// Interface - defines a contract
public interface IElectric
{
    int BatteryCapacity { get; set; }
    void Charge();
    void DisplayBatteryStatus();
}

// Concrete class implementing abstract class
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string brand, string model, int numberOfDoors) : base(brand, model)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void Start()
    {
        Console.WriteLine($"{Brand} {Model} car engine started.");
    }

    public override void Stop()
    {
        Console.WriteLine($"{Brand} {Model} car engine stopped.");
    }
}

// Concrete class implementing both abstract class and interface
public class ElectricCar : Vehicle, IElectric
{
    public int BatteryCapacity { get; set; }
    private int currentCharge;

    public ElectricCar(string brand, string model, int batteryCapacity) : base(brand, model)
    {
        BatteryCapacity = batteryCapacity;
        currentCharge = batteryCapacity / 2; // Start with 50% charge
    }

    public override void Start()
    {
        if (currentCharge > 0)
        {
            Console.WriteLine($"{Brand} {Model} electric motor started silently.");
        }
        else
        {
            Console.WriteLine($"{Brand} {Model} cannot start - battery empty!");
        }
    }

    public override void Stop()
    {
        Console.WriteLine($"{Brand} {Model} electric motor stopped.");
    }

    public void Charge()
    {
        currentCharge = BatteryCapacity;
        Console.WriteLine($"{Brand} {Model} battery fully charged to {BatteryCapacity} kWh!");
    }

    public void DisplayBatteryStatus()
    {
        int percentage = (currentCharge * 100) / BatteryCapacity;
        Console.WriteLine($"Battery Status: {currentCharge}/{BatteryCapacity} kWh ({percentage}%)");
    }
}

// Another concrete class implementing abstract class
public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(string brand, string model, bool hasSidecar) : base(brand, model)
    {
        HasSidecar = hasSidecar;
    }

    public override void Start()
    {
        Console.WriteLine($"{Brand} {Model} motorcycle engine roared to life.");
    }

    public override void Stop()
    {
        Console.WriteLine($"{Brand} {Model} motorcycle engine stopped.");
    }
}
