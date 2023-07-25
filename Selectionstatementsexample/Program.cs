namespace Selectionstatementsexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;

            if(condition)
            {
                Console.WriteLine("This is true");

            }
            else //else is for if the boolean is false
            {
                Console.WriteLine("This is false");
            }

            int a = 10;
            int b = 5;

            if(a == b)
            {
                Console.WriteLine("a is equal to b");
            }
            else if(b < a && a == b)
            {
                Console.WriteLine("b is less than a"); //it will only print the one that is true
            }
            else
            {
                Console.WriteLine("none of these are true");
            }
            int i = -1;
                string positiveMessage = (i > 0) ? "You are positive" : "You are not positive"; //ternerary statement
            Console.WriteLine(positiveMessage); //? acts as you if statement; and : acts as your else statement
            //you can do multiple statements, you just have to repeat the () ? "" : ""

            int day = 2; //you can either give switch statements string or int; etc. types to search through

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday"); //case statements can also have multiple cases before a break to check through
                    break;
                case 2:
                    Console.WriteLine("Monday");//it would catch case 2 "Monday"
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Not a day of the week");
                    break;

            }

        }
    }
}