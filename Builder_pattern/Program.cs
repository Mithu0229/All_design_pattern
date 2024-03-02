/*
 What is the Builder Design Pattern? According to the Gang of Four (GoF), the Builder Design Pattern builds a complex object 
using many simple objects and a step-by-step approach. The key idea is to separate the construction of a complex object from 

its representation. The same construction process can be used to create different representations of the same complex object.
Real-Time Example: Building a Laptop Imagine building a laptop—a complex object. To construct a laptop, we need to assemble 
various small components like LCD displays, USB ports, wireless modules, hard drives, batteries, keyboards, and plastic cases. 
The generic process might look like this:
Plug in the memory.
Plug in the hard drive.
Plug in the battery.
Plug in the keyboard.
Cover the laptop with a plastic case.
Using this process, we can create different types of laptops: 14-inch or 17-inch screens, laptops with 4GB or 8GB RAM, and so on.
All laptop creations follow the same generic process.
When to Use the Builder Design Pattern? The Builder pattern is particularly useful when:
Constructing objects with many optional components or configurations.
The construction process of your object is complex
 */

var restaurant = new Restaurant();
var customMealBuilder = new CustomMealBuilder();
var customMeal = restaurant.CreateCustomMeal(customMealBuilder);

Console.WriteLine(customMeal);


// Abstract builder interface
public interface IMealBuilder
{
    void AddMainCourse(string mainCourse);
    void AddSideDish(string sideDish);
    void AddBeverage(string beverage);
    string GetMeal();
}

// Concrete builder
public class CustomMealBuilder : IMealBuilder
{
    private string meal = "Custom Meal: ";

    public void AddMainCourse(string mainCourse)
    {
        meal += mainCourse + ", ";
    }

    public void AddSideDish(string sideDish)
    {
        meal += sideDish + ", ";
    }

    public void AddBeverage(string beverage)
    {
        meal += beverage;
    }

    public string GetMeal()
    {
        return meal;
    }
}

// Director (client)
public class Restaurant
{
    public string CreateCustomMeal(IMealBuilder builder)
    {
        builder.AddMainCourse("Burger");
        builder.AddSideDish("Fries");
        builder.AddBeverage("Coke");
        return builder.GetMeal();
    }
}

