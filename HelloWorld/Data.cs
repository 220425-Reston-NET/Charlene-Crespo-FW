public class Data 
{
    private string _guestName;
    public string Name
    {
        get {return _guestName;}
        set {_guestName = value;}

    }
    private string _phones;
    private string _tablets;
    private string _laptops;
    private int _phonesPrice;
    private int _tabletsPrice;
    private int _laptopsPrice;
    private int _totalPrice;
    private string _totalCart;
    
    public Data()
    {
        _guestName = "Charlene";
        _phones = "Phones";
        _tablets = "Tablets";
        _laptops = "Laptops";
        _totalCart = "Total";
        
        
        _phonesPrice = 100;
        _tabletsPrice = 140;
        _laptopsPrice = 200;
        _totalPrice = 0;
    }
       List<string>_shoppingCart = new List<string>(); 
        List<int>_itemList = new List<int>();
        
        public void greetingMenu()
        {   
            Console.WriteLine("Welcome " + _guestName + " What can i do for you today?");
            Console.WriteLine("1. To Add Item");
            Console.WriteLine("2. To Remove Item");
            Console.WriteLine("3. To View Cart");
            Console.WriteLine("4. To Search Item");
            Console.WriteLine("5. To Checkout");            
        } 

        public void Search()
        {
            Console.WriteLine("Which item would you like to search");
            string searchItem = Console.ReadLine();

            bool searchMatch = false;
            foreach(string item in _shoppingCart)
            {
                if(searchItem == item)
                {
                    searchMatch = true;
                }
            }

            if (searchMatch)
            {
                Console.WriteLine("Item was found");
            }

            else 
            {
                Console.WriteLine("Item not found");
                
            } 

        }   
            public void ViewItem()
            {
                Console.WriteLine("These are the items in your cart");
                foreach(string element in _shoppingCart)
                {
                    Console.WriteLine(element);
                }
            }
                     
            public void AddItem()
                {
                    bool repeat = true;
                    while (repeat)
                    {
                        Console.WriteLine("1. Phones $" + _phonesPrice);
                        Console.WriteLine("2. Tablets $" + _tabletsPrice);
                        Console.WriteLine("3. Laptops $" + _laptopsPrice);
                        string answer = Console.ReadLine();
                        if(answer == "1")
                        {
                            Console.Clear();
                            _totalCart +=  _phonesPrice;
                            Console.WriteLine("Your total is now $" + _totalCart);
                            _itemList.Add(_phonesPrice);
                        }

                        else if (answer == "2")
                        {
                            Console.Clear();
                            _totalCart +=  _tabletsPrice;
                            Console.WriteLine("Your total is now $" + _totalCart);
                            _itemList.Add(_tabletsPrice);
                        }

                        else if(answer == "3")
                        {
                            Console.Clear();
                            _totalCart +=  _laptopsPrice;
                            Console.WriteLine("Your total is now $" + _totalCart);
                            _itemList.Add(_laptopsPrice);
                       
                        }
                    }        
                   
                }
                 public void RemoveItem()
                {
                    Console.WriteLine("Which item would you like to remove?");
                    string item1 = Console.ReadLine();

                    bool match = false;

                    foreach (string item in _shoppingCart)
                    {
                        if (item1 == item)
                        {
                            match = true;
                        }
                    }

                    if (match)
                    {
            
                        _shoppingCart.Remove(item1);
                        if(item1 == "Phones")
                        {
                            _itemList.Remove(_phonesPrice);
                        }
                        
                        else if(item1 == "Tablets")
                        {
                            _itemList.Remove(_tabletsPrice);
                        }
        
                        else if(item1 == "Laptops")
                        {
                            _itemList.Remove(_laptopsPrice);
                        }

                        Console.WriteLine("Item removed");
                    }
                    else
                    {
                        Console.WriteLine("Item not found. No items were removed.");
                    }
                }   
   }   

            
        
          
