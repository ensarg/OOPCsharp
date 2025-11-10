# OOPCsharp

A comprehensive demonstration of Object-Oriented Programming (OOP) principles in C#.

## Overview

This project demonstrates the four fundamental pillars of Object-Oriented Programming:

1. **Encapsulation** - Hiding internal state and controlling access through methods
2. **Inheritance** - Creating new classes based on existing classes
3. **Polymorphism** - Objects taking multiple forms with the same interface
4. **Abstraction** - Hiding complex implementation details

## Project Structure

```
OOPCsharp/
├── Examples/
│   ├── Encapsulation.cs    - BankAccount example
│   ├── Inheritance.cs      - Animal hierarchy (Dog, Cat, Bird)
│   ├── Polymorphism.cs     - Shape hierarchy (Circle, Rectangle, Triangle)
│   └── Abstraction.cs      - Vehicle abstraction with interfaces
├── Program.cs              - Main program demonstrating all concepts
├── OOPExamples.csproj     - Project configuration
└── README.md              - This file
```

## OOP Concepts Demonstrated

### 1. Encapsulation
**File:** `Examples/Encapsulation.cs`

The `BankAccount` class demonstrates encapsulation by:
- Using private fields to hide internal state
- Providing public properties for controlled read access
- Using public methods for controlled operations (Deposit, Withdraw)
- Validating inputs to maintain data integrity

### 2. Inheritance
**File:** `Examples/Inheritance.cs`

The Animal hierarchy demonstrates inheritance:
- **Base class:** `Animal` (with Name, Age, MakeSound, DisplayInfo)
- **Derived classes:** 
  - `Dog` - adds Breed and Fetch behavior
  - `Cat` - adds IsIndoor and Climb behavior
  - `Bird` - adds WingSpan and Fly behavior

Each derived class inherits properties and methods from Animal while adding its own unique features.

### 3. Polymorphism
**File:** `Examples/Polymorphism.cs`

The Shape hierarchy demonstrates polymorphism:
- **Base class:** `Shape` with virtual methods
- **Derived classes:** `Circle`, `Rectangle`, `Triangle`
- Each shape overrides `CalculateArea()` with its own implementation
- Shapes can be treated uniformly through the Shape base class reference

### 4. Abstraction
**File:** `Examples/Abstraction.cs`

Demonstrates abstraction through:
- **Abstract class:** `Vehicle` (cannot be instantiated directly)
  - Abstract methods: `Start()`, `Stop()` (must be implemented)
  - Concrete method: `DisplayInfo()` (shared implementation)
- **Interface:** `IElectric` (defines a contract)
  - Properties and methods for electric vehicles
- **Concrete classes:**
  - `Car` - implements Vehicle
  - `ElectricCar` - implements both Vehicle and IElectric
  - `Motorcycle` - implements Vehicle

## Requirements

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download) or later

## How to Run

1. Clone this repository:
   ```bash
   git clone https://github.com/ensarg/OOPCsharp.git
   cd OOPCsharp
   ```

2. Build the project:
   ```bash
   dotnet build
   ```

3. Run the project:
   ```bash
   dotnet run
   ```

## Expected Output

The program will demonstrate all four OOP pillars with interactive examples:

- **Encapsulation:** Bank account operations with balance management
- **Inheritance:** Different animals making sounds and performing unique behaviors
- **Polymorphism:** Various shapes calculating their areas using the same interface
- **Abstraction:** Different vehicles with starting/stopping behaviors, including electric vehicles

## Learning Objectives

After studying this code, you should understand:

- How to hide data using private fields and expose it through properties
- How to create class hierarchies using inheritance
- How to override virtual methods for polymorphic behavior
- How to use abstract classes and interfaces for abstraction
- The benefits of OOP in creating maintainable and extensible code

## Additional Resources

- [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [OOP Concepts in C#](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/)

## License

This project is for educational purposes.
