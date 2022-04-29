public class Collections
{
//Array
//Used to stotre a datatype and have fixed sizes
//Syntax datatype[] (nameofVariable) = new (datatype)[sizeofArray]

int[] _numberArray = new int[5];

public void CollectionMain()
{

    Console.WriteLine("==Array Demo==");
    //Allows us to se what tos tore in certain positions

    _numberArray[0] = 3;
    _numberArray[1] = 10;
    _numberArray[2] = 100;


    foreach(int element in _numberArray)
    {
        Console.WriteLine(element);
    }
}

}