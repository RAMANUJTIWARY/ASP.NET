namespace basic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 10;
            const int b=20;
           // b = 10;  it  shows error because const value can't be changed
            Console.WriteLine("Hello, World!");
            Console.WriteLine("value of a is : "+a);
            Console.WriteLine("value of b is : "+b);
            Console.WriteLine(100+200); //literal
        }
    } 
}
