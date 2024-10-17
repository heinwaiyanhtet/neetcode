class Program
{

    static void AddTen(ref int number)
    {
        number += 10;
    }

    static void GetValues(out int number1,out int number2)
    {
        number1 = 10;
        number2 = 20;
    }

    static void Main(string[] args)
    {

            int myNumber = 5;
            Console.WriteLine("Before calling AddTen: " + myNumber);

            AddTen(ref myNumber);

            Console.WriteLine($"After ref method: {myNumber}");  




            int a , b;

            GetValues(out a, out b);

            Console.WriteLine($"Out method values: a = {a}, b = {b}");  

            Console.ReadLine();  
    }
}