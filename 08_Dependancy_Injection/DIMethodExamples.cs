using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Dependancy_Injection
{
    public interface ICurrency
    {
        string Name { get; }
        decimal Value { get; }
    }

    class Penny : ICurrency
    {
        public string Name { get => "Penny"; }
        public decimal Value { get => 0.01m; }
    }
    class Nickel : ICurrency
    {
        public string Name { get => "Nickel"; }
        public decimal Value { get => 0.05m; }
    }
    class Dime : ICurrency
    {
        public string Name { get => "Dime"; }
        public decimal Value { get => 0.1m; }
    }
    class Quarter : ICurrency
    {
        public string Name { get => "Quarter"; }
        public decimal Value { get => 0.25m; }
    }
    class Dollar : ICurrency
    {
        public string Name { get => "Dollar"; }
        public decimal Value { get => 1.0m; }
    }
    class ElectronicPayment : ICurrency
    {
        public string Name { get => "Electronic Payment"; }
        public decimal Value { get; }
        public ElectronicPayment(decimal value)
        {
            Value = value;
        }
    }


    [TestClass]
    public class DIMethodExamples
    {
        decimal _debt = 100000.0m;
        [TestMethod]
        public void DIMethodExample()
        {
            Pay(new Dollar());
            Pay(new Penny());
            Pay(new ElectronicPayment(20.0m));
            Console.WriteLine("$"+_debt);
        }
        public void Pay(ICurrency currency)
        {
            _debt -= currency.Value;
            Console.WriteLine($"You paid ${currency.Value}, Debt: ${_debt}");
        }
    }

    class Transaction
    {
        private readonly ICurrency _amount; //just like saying private ICurrency _amount { get; }
        public DateTimeOffset DateOfTransaction { get; set; }
        public Transaction(ICurrency currency)
        {
            _amount = currency;
            DateOfTransaction = DateTimeOffset.Now;
        }

        public decimal GetTransactionAmount()
        {
            return _amount.Value;
        }
        public string GetPaymentTypeOfTransaction()
        {
            return _amount.Name;
        }
    }
    [TestClass]
    public class ConstructorDI
    {
        [TestMethod]
        public void InjectingIntoConstructors()
        {
            Dollar dollar = new Dollar();
            Transaction firstTransaction = new Transaction(dollar);
            Transaction secondTransaction = new Transaction(new ElectronicPayment(20.0m));

            Console.WriteLine(firstTransaction.GetTransactionAmount());
            Console.WriteLine(firstTransaction.GetPaymentTypeOfTransaction());
            Console.WriteLine(secondTransaction.GetPaymentTypeOfTransaction());
        }
    }
}
