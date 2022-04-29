public class Menu
{
      private string _name;
      public string Name
      {
            get{return _name;}
            set{_name = value;}
      }
      private int _phonesPrice;
      private int _tabletsPrice;
      private int _laptopsPrice;
      private int _totalPrice;
      public int TotalPrice

      {
            get{ return _totalPrice;}
            set{ _totalPrice = value;}
      }
            
      public Menu()
      {
            _name = "Charlene";
            _phonesPrice = 100;
            _tabletsPrice = 120;
            _laptopsPrice = 140;
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
            bool repeat = true;
            while (repeat)
            {
                  
                  Console.WriteLine("1 - phones $" + _phonesPrice);
                  Console.WriteLine("2 - tablets $" + _tabletsPrice);
                  Console.WriteLine("3 - laptops $" + _laptopsPrice);
                  string answer = Console.ReadLine();
            
                  if (answer == "1")
                  {
                        Console.WriteLine("Phones $100");
                        _totalPrice += _phonesPrice;
                  }
                  else if (answer == "2")
                  {
                        Console.WriteLine("Tablets $120");
                        _totalPrice += _tabletsPrice;
                  }
                  else if (answer == "3")
                  {
                        Console.WriteLine("Laptops $140");
                        _totalPrice += _laptopsPrice;
                  }
            }
      }
}
