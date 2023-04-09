// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


///Span<T>>
var span = new Span<string>();




//Non-Trailing argument names

DoSomething(33, 44);
void DoSomething(int foo, int bar)
{

}


//Private protected


Base b = new Base();
public class Base
{
    private int a;

    protected internal int b; //1) derived classes (any assembly)
                                //2) classes in same assembly

    private protected int c; //Containing class
                            //derived classes (current assembly)
}

class Derived : Base
{
    public Derived()
    {
        b = 222;
        c = 333;
    }
}





