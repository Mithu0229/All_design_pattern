/*
 The Factory Method pattern is a creational design pattern that allows you to create objects without tightly coupling 
the object creation code to the client code. It provides an interface for creating objects, but lets subclasses decide 
which class to instantiate.

Here are the key components of the Factory Method pattern:

Creator (Abstract Creator):
An abstract class or interface that declares the FactoryMethod().
It defines the contract for creating objects.
Concrete creators (subclasses) implement this method to produce instances of concrete products.
Concrete Creator:
Subclasses of the creator that implement the FactoryMethod().
Each concrete creator produces instances of specific concrete products.
Product (Abstract Product):
An interface or abstract class that defines the operations that concrete products must implement.
Represents the type of objects created by the factory method.
Concrete Product:
Classes that implement the product interface.
Represent the actual objects created by the factory method.


In this example:

We have three credit card types: MoneyBack, Titanium, and Platinum.
Each credit card type implements the ICreditCard interface.
The CreditCardFactory abstract class declares the CreateProduct() method.
Concrete factories (MoneyBackFactory, TitaniumFactory, and PlatinumFactory) create specific credit card instances.
Remember that the Factory Method Design Pattern allows you to create objects dynamically based on the client’s requirements.
It promotes loose coupling and flexibility in object creation
 */

CreditCardFactory factory = new MoneyBackFactory();
ICreditCard card = factory.CreateProduct();

Console.WriteLine($"Card Type: {card.GetCardType()}");
Console.WriteLine($"Credit Limit: {card.GetCreditLimit()}");
Console.WriteLine($"Annual Charge: {card.GetAnnualCharge()}");


//Console.WriteLine("test money bank");
//MoneyBack m= new MoneyBack();
//Console.WriteLine(m.GetCreditLimit());

// Abstract Product
public interface ICreditCard
{
    string GetCardType();
    decimal GetCreditLimit();
    decimal GetAnnualCharge();
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
public class Titanium : ICreditCard
{
    public decimal GetAnnualCharge()
    {
        return 20;
    }

    public string GetCardType()
    {
        return typeof( Titanium ).Name;
    }

    public decimal GetCreditLimit()
    {
        return 15;
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

// Abstract Creator
public abstract class CreditCardFactory
{
    public abstract ICreditCard CreateProduct();
}

// Concrete Creators
public class MoneyBackFactory : CreditCardFactory
{
    public override ICreditCard CreateProduct() => new MoneyBack();
}

public class TitaniumFactory : CreditCardFactory
{
    public override ICreditCard CreateProduct() => new Titanium();
}

public class PlatinumFactory : CreditCardFactory
{
    public override ICreditCard CreateProduct() => new Platinum();
}

// Client Code

