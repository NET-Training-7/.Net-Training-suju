class Vehicle
{
    
    internal string Vendor //ctrl+Alt+downarrow
    internal string vehiclenumber;
    internal string model;
    internal string type;
    internal byte nWheels;
    internal float Milage;

    void PrintDetails()
    {
        var vDetails=$"Its {nWheels} wheeler {model} {type} from {Vendor} and the vehicle lot number is {vehiclenumber} which gives {Milage} milage.";
        Console.WriteLine(vDetails);
    }

}

