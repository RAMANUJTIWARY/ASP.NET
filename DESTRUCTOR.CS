namespace Destructor
{
    public class Destructor1
    {
        int age=25;
        string name="ramanuj";
        public void getAge()
        {

            this.age = age;
            Console.WriteLine(age);
        }
        public void getName()
        {
            this.name = name;
            Console.WriteLine(name);
        }
        ~Destructor1()
        {
            Console.WriteLine("destroyed!!");
        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Destructor1 d1=new Destructor1();
            
            d1.getName();
            d1.getAge();

        }
    }
}
