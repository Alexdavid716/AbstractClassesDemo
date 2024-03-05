using System;

public class Car : Vehicle
{
    
    public bool HasTrunk { get; set; }

    
    public Car()
    {
       
        Make = "GenericCar";
        Model = "GenericModel";
    }

    
    public override void DriveAbstract()
    {
        Console.WriteLine($"This {Year} {Make} {Model} is being driven (abstract method).");
    }
}
