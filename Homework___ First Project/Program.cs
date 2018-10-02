using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework____First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
           



            System.Console.Write(" Enter your First Name? : ");
            string firstname = System.Console.ReadLine();

            System.Console.Write(" Enter your middle Intial? ");
            string middleinitial = System.Console.ReadLine();

            System.Console.Write(" Enter your Last Name? ");
            string lastname = System.Console.ReadLine();
          
           
       

             string fullName = firstname + " " + middleinitial + lastname;

            Console.WriteLine("Enter your full name");
            Console.ReadLine();

            
                const double multiplier = 2.54;
                int inInches = 11;

                System.Console.Write("Height in feet");
                int heightInfeet = int.Parse(System.Console.ReadLine());

                System.Console.Write("Extra inches :");
                double heightIninches = double.Parse(System.Console.ReadLine());


                double inches = heightIninches * heightInfeet;

                double centimeters = inches * multiplier;

                System.Console.WriteLine(centimeters);


                System.Console.Write("How old are you :");
                int age = int.Parse(System.Console.ReadLine());
           

            System.Console.Write("Are you a citizen of Tanzania :");
            bool isCitizen = bool.Parse(System.Console.ReadLine());


            bool canVote = (age >= 18 && isCitizen);

            System.Console.WriteLine(canVote);
            Console.ReadLine();







            Console.ReadKey();

        }
    }
}
