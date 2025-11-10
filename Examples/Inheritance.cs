namespace OOPExamples.Examples;

/// <summary>
/// Demonstrates Inheritance - creating new classes based on existing classes,
/// inheriting their properties and methods.
/// </summary>

// Base class (Parent class)
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age} years");
    }
}

// Derived class (Child class) - Dog
public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the {Breed} barks: Woof! Woof!");
    }

    public void Fetch()
    {
        Console.WriteLine($"{Name} is fetching the ball!");
    }
}

// Derived class (Child class) - Cat
public class Cat : Animal
{
    public bool IsIndoor { get; set; }

    public Cat(string name, int age, bool isIndoor) : base(name, age)
    {
        IsIndoor = isIndoor;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} meows: Meow! Meow!");
    }

    public void Climb()
    {
        Console.WriteLine($"{Name} is climbing a tree!");
    }
}

// Derived class (Child class) - Bird
public class Bird : Animal
{
    public double WingSpan { get; set; }

    public Bird(string name, int age, double wingSpan) : base(name, age)
    {
        WingSpan = wingSpan;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} chirps: Tweet! Tweet!");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying with a wingspan of {WingSpan} cm!");
    }
}
