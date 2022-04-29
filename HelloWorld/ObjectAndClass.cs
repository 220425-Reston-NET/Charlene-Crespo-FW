//This is how you create a class by using the class keyword
//public is just there to make the class available to eveyone
public class Car
{
   //This is a Field 
   //It is used to store information or define the current state of the object
   public string _color;
   public string _owner;
   public int _fuel;
   public int _gallonPerMile;

public int TotalDistancePerFuel()
{
    Console.WriteLine("Current Fuel:" +_fuel + " This is the owner: " + _owner);
    Console.WriteLine($"Gallon Per Mile: {_gallonPerMile} This is the owner: {_owner}");

    Console.WriteLine("This is how many miles: " + _fuel/_gallonPerMile);

    return _fuel/_gallonPerMile;
}
public void Sum(int num1, int num2)
{
    Console.WriteLine(num1+num2);
}
public Car()
{
    _color = "Blue";
    _fuel = 100;
    _gallonPerMile = 5;
    _owner = "Charlene";
}
public Car(string p_owner)
{
    _owner = p_owner;
}

public string owner
{
    get {return _owner + "is the owner of this car.";}

    set {_owner=value+" Owner";}
}

public int Fuel
{
    get {return _fuel;}

    set
    {
        if (value <= 100 && value >= 0)
        {
            _fuel = value;
            Console.WriteLine("Fuel can only hold from 0 to 100");
        }
    }
}
}
