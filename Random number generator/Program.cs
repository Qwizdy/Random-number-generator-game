using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Random_number_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            var num = r.Next(1, 11);
            Console.WriteLine(num);
            Console.WriteLine("Guess a number between one and ten");
            var Usernum=Console.ReadLine();
           var parsesuc=int.TryParse (Usernum, out int usernumber);
            if (parsesuc == false)
            { 

            Console.WriteLine("you didn't input a number, please try again"); 

            }
            if (usernumber == num)
            Console.WriteLine ("You got it :3") ;

            if (parsesuc == Usernum)
                Console.WriteLine("you got it wrong");
           


        }

    }
}
