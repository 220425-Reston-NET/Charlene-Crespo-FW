//This is how you create a class by using the class keyword
//public is just there to make the class available to eveyone
public class Car
{
   //This is a Field 
   //It is used to store information or define the current state of the object
   public string _color = "Blue";
   
   public string _owner = "Charlene";

public int _fuel = 100;
public int _gallonPerMile = 5;

public void TotalDistancePerFuel()
{
    Console.WriteLine("Current Fuel:" +_fuel);
    Console.WriteLine($"Gallon Per Mile: {_gallonPerMile} This is the owner: {_owner}");

}



}