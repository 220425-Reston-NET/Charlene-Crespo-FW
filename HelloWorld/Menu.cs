public class Menu
{
      private string _name;
      public string Name
      {
            get{return _name;}
            set{_name = value;}
      }
private int _iphones;
private int _tablets;
private int _laptops;
private int _tvs;
private int _totalPrice;
public int TotalPrice
{
      get{ return _totalPrice;}
      set{_totalPrice = value;}
}

public Menu()
{
      _name = "Charlene";
      _iphones = 100;
      _tablets = 120;
      _laptops = 140;
      _tvs = 200;
}

public void GreetUser()
{
      Console.Clear();
      Console.WriteLine("Hello " + _name + "! How can i help you today?");
      Console.WriteLine("1. Type of Repairs");
      Console.WriteLine("2. Checkout");
}

public void Repairs()
{
      Console.WriteLine("1 - iphones $ " + _iphones);
      Console.WriteLine("2 - tablets $" + _tablets);
      Console.WriteLine("3 - laptops $" + _laptops);
      Console.WriteLine("4 - tvs $" + _tvs);
      string answer = Console.ReadLine();
      if (answer == "1")
      {
            _totalPrice += _iphones;
      }
      else if (answer == "2")
      {
            _totalPrice += _tablets;
      }
      else if (answer == "3")
      {
            _totalPrice += _laptops;
      }
      else if (answer == "4")
      {
            _totalPrice += _tvs;
      }
      Console.WriteLine("Your current total is: " + _totalPrice);
}
}

        