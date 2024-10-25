// Using Ref to modify existing value


// public class RefOutExample
// {
//     public void ModifyRefParameter(ref int number)
//     {
//         Console.WriteLine("Initial ref value:" + number);
//         number += 10;
//     }   


//     public void AssignOutParameter(out int number)
//     {
//         number = 20;
//     }
// }


// public class RefExample
// {
//     public void DoubleValue(ref int number)
//     {
//         number *= 2;
//     }
// }





// // Using out to assign calculated value

// public class OutExample
// {
//     public bool TryParseInt(string input,out int result)
//     {
//         bool success = int.TryParse(input, out result);
//         return success;
//     }
// }


public class Calculator
{

    public void AddToExistingValue(ref int existingValue,int addend)
    {
        existingValue += addend;
    }


    public bool TryDivide(int dividend, int divisor, out int result)
    {
        
            if(divisor == 0)
            {
                result = 0;
                return false;
            }

            result = dividend / divisor;

            return true;
    }
}


public class Program
{
    public static void Main(string[] args)
    {

            var calculator = new Calculator();


            int total = 50;
            calculator.AddToExistingValue(ref total, 10);
            Console.WriteLine("Updated total using ref: " + total);


            int divisionResult;
            bool isDivisible = Calculator.TryDivide(100, 10, out divisionResult);

             if (isDivisible)
                  Console.WriteLine("Division result using out: " + divisionResult); // Output: 5
                  
             else
                  Console.WriteLine("Cannot divide by zero.");
        






            // var example = new OutExample();

            // int parsedValue;
            // bool isParsed = example.TryParseInt("123", out parsedValue);

            // if(isParsed)
            // {
            //     Console.WriteLine("Parsed value using out: " + parsedValue); 
            // }
            // else
            // {
            //     Console.WriteLine("failed to parse the input");
            // }





            // int value = 10;
            // var example = new RefExample();

            // example.DoubleValue(ref value);
            // Console.WriteLine("Double value using ref" + value);





            // var example = new RefOutExample();

            // // using ref
            // int refValue = 10;
            // example.ModifyRefParameter(ref refValue);




            // //using out

            // int outValue;
            // example.AssignOutParameter(out outValue);
            // Console.WriteLine("Assign out value: " + outValue);
    }
}


