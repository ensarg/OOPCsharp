using OOPExamples.Examples;

namespace OOPExamples;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("   Object-Oriented Programming in C#");
        Console.WriteLine("   Demonstrating the Four Pillars of OOP");
        Console.WriteLine("==============================================\n");

        // 1. ENCAPSULATION
        Console.WriteLine("\n********** 1. ENCAPSULATION **********");
        Console.WriteLine("Hiding internal state and requiring interaction through methods\n");
        
        BankAccount account = new BankAccount("ACC123456", "John Doe", 1000);
        account.DisplayAccountInfo();
        account.Deposit(500);
        account.Withdraw(300);
        account.Withdraw(2000); // This will fail
        account.DisplayAccountInfo();

        // 2. INHERITANCE
        Console.WriteLine("\n********** 2. INHERITANCE **********");
        Console.WriteLine("Creating new classes based on existing classes\n");
        
        Dog dog = new Dog("Buddy", 3, "Golden Retriever");
        Cat cat = new Cat("Whiskers", 2, true);
        Bird bird = new Bird("Tweety", 1, 25.5);

        dog.DisplayInfo();
        dog.MakeSound();
        dog.Fetch();
        Console.WriteLine();

        cat.DisplayInfo();
        cat.MakeSound();
        cat.Climb();
        Console.WriteLine();

        bird.DisplayInfo();
        bird.MakeSound();
        bird.Fly();

        // 3. POLYMORPHISM
        Console.WriteLine("\n\n********** 3. POLYMORPHISM **********");
        Console.WriteLine("Objects taking multiple forms - same method, different behavior\n");
        
        // Using polymorphism - Shape reference to different objects
        Shape[] shapes = new Shape[]
        {
            new Circle("Red", 5),
            new Rectangle("Blue", 4, 6),
            new Triangle("Green", 3, 4)
        };

        foreach (Shape shape in shapes)
        {
            shape.Display();
            Console.WriteLine($"Area: {shape.CalculateArea():F2} square units\n");
        }

        // 4. ABSTRACTION
        Console.WriteLine("\n********** 4. ABSTRACTION **********");
        Console.WriteLine("Hiding complex details and showing only essential features\n");
        
        Car normalCar = new Car("Toyota", "Camry", 4);
        normalCar.DisplayInfo();
        normalCar.Start();
        normalCar.Stop();
        Console.WriteLine();

        ElectricCar tesla = new ElectricCar("Tesla", "Model 3", 75);
        tesla.DisplayInfo();
        tesla.DisplayBatteryStatus();
        tesla.Start();
        tesla.Charge();
        tesla.DisplayBatteryStatus();
        tesla.Stop();
        Console.WriteLine();

        Motorcycle bike = new Motorcycle("Harley-Davidson", "Street 750", false);
        bike.DisplayInfo();
        bike.Start();
        bike.Stop();

        Console.WriteLine("\n==============================================");
        Console.WriteLine("   End of OOP Demonstrations");
        Console.WriteLine("==============================================");
    }
}
