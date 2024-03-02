/*
 the Abstract Factory Design Pattern provides a way to encapsulate a group of factories with a common theme without 
specifying their concrete classes. Here’s what each component of the pattern entails:

AbstractFactory:
Declares an interface for operations that create abstract products.
Provides an interface for creating abstract product objects.
ConcreteFactory:
Implements the operations to create concrete product objects.
These classes implement the Abstract Factory interface and provide implementations for the interface methods.
Concrete factories create specific product instances.
AbstractProduct:
Declares an interface for a type of product object.
Defines the operations a product should have.
These are interfaces for creating abstract products.
ConcreteProduct:
Implements the AbstractProduct interface.
Represents the actual product instances.
These classes implement the Abstract Product interface.
Client:
Uses interfaces declared by AbstractFactory and AbstractProduct classes.
Creates a family of related products.
 */

//client code
var factory = new MoneyBackFactory();
var creditCard = factory.CreateCreditCard();
var vehicle = factory.CreateVehicle();

Console.WriteLine($"Credit Card Type: {creditCard.GetType().Name}");
Console.WriteLine($"Vehicle Type: {vehicle.GetType().Name}");

// Abstract product
public interface ICreditCard
{
    string GetCardType();
    decimal GetCreditLimit();
    decimal GetAnnualCharge();
}
// Abstract product
public interface IVehicle
{
    string GetModel();
}

// Concrete Products
public class MoneyBack : ICreditCard
{
    public decimal GetAnnualCharge()
    {
        return 10;
    }

    public string GetCardType()
    {
        return "Money back";
    }

    public decimal GetCreditLimit()
    {
        return 5;
    }
}

public class Platinum : ICreditCard
{
    public decimal GetAnnualCharge()
    {
        return 30;
    }

    public string GetCardType()
    {
        return nameof(Platinum);
    }

    public decimal GetCreditLimit()
    {
        return 25;
    }
}

// Concrete Products

public class Car : IVehicle
{
    public string GetModel()
    {
        return typeof(Car).Name;
    }
}

public class Bike : IVehicle
{
    public string GetModel()
    {
        return typeof(Bike).Name;
    }
}

// Abstract factory

public interface ICardFactory
{
    ICreditCard CreateCreditCard();
    IVehicle CreateVehicle();
}
// concrate factory
public class MoneyBackFactory : ICardFactory
{
    public ICreditCard CreateCreditCard() => new MoneyBack();
    public IVehicle CreateVehicle() => new Car();
}
// concrate factory
public class PlatinumFactory : ICardFactory
{
    public ICreditCard CreateCreditCard() => new Platinum();
    public IVehicle CreateVehicle() => new Bike();
}