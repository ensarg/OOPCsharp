namespace OOPExamples.Examples;

/// <summary>
/// Demonstrates Encapsulation - hiding internal state and requiring all interaction
/// to be performed through an object's methods.
/// </summary>
public class BankAccount
{
    // Private fields - encapsulated data
    private string accountNumber;
    private string accountHolder;
    private decimal balance;

    // Public properties - controlled access to data
    public string AccountNumber => accountNumber;
    public string AccountHolder => accountHolder;
    public decimal Balance => balance;

    // Constructor
    public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = initialBalance >= 0 ? initialBalance : 0;
    }

    // Public methods - controlled operations
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"\n--- Account Information ---");
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Account Holder: {accountHolder}");
        Console.WriteLine($"Current Balance: {balance:C}");
        Console.WriteLine("---------------------------\n");
    }
}
