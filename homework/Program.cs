using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
 

        {
          
            //// 1. uzdevums

            Console.WriteLine("Kāds ir tavs vārds?");

            string username = Console.ReadLine();

            Console.WriteLine("Sveiki," + username);

            //// 2. uzdevums

            Console.WriteLine("Kāds ir tavs vecums?");

            string userage = Console.ReadLine();

            int age = int.Parse(userage);
            int agenextyear = age + 1;

            Console.WriteLine("Nakamgad tev paliks," + agenextyear);

            //// 3. uzdevums

            Console.WriteLine("Ievadiet divus skaitļus.");

            string usernumber1 = Console.ReadLine();
            string usernumber2 = Console.ReadLine();

            int number1 = int.Parse(usernumber1);
            int number2 = int.Parse(usernumber2);

            int maxresult = Math.Max(number1, number2);

            Console.WriteLine("Lielākais no šiem skaitļiem ir," + maxresult);

            //// 4. uzdevums

            Console.WriteLine("Ievadiet divus skaitļus.");

            string usernumber3 = Console.ReadLine();
            string usernumber4 = Console.ReadLine();

            int number3 = int.Parse(usernumber3);
            int number4 = int.Parse(usernumber4);

            int minresult = Math.Min(number3, number4);

            Console.WriteLine("Mazākais no šiem skaitļiem ir," + minresult);

            

            //// 5. uzdevums

            // nezinu kā pareizi atrādīt dalījuma atlikumu, atradu cita koda paraugu internetā.

            Console.WriteLine("Ievadiet dalāmo skaitli.");
            string usernumber5 = Console.ReadLine();

            Console.WriteLine("Ievadiet dalītāja skaitli.");
            string usernumber6 = Console.ReadLine();


            float number5 = Single.Parse(usernumber5);
            float number6 = Single.Parse(usernumber6);

            Console.WriteLine("{0:N} / {1:N1} = {2:N4}", number5, number6, number5/number6);


            ////6. uzdevums

            Console.WriteLine("Ievadiet skaitli");
            string usernumber7 = Console.ReadLine();

            int number7 = int.Parse(usernumber7);

            if (number7%2 != 1) 
            { 
            Console.WriteLine("Skaitlis ir pāra");
            }
            else 
            {
            Console.WriteLine("Skaitlis ir nepāra");
            }


            //// 7. uzdevums

            Console.WriteLine("Ievadiet taisnstūra garumu.");

            string usergarums = Console.ReadLine();
            decimal garums = decimal.Parse(usergarums);


            Console.WriteLine("Ievadiet taisnstūra platumu.");

            string userplatums = Console.ReadLine();
            decimal platums = decimal.Parse(userplatums);

            decimal laukums = garums * platums;

            Console.WriteLine("Taisnstūra laukums ir" + " " + laukums);

            //// 8. uzdevums

            Console.WriteLine("Ievadiet trjstūra garumu.");

            string usergarums2 = Console.ReadLine();
            decimal garums2 = decimal.Parse(usergarums2);


            Console.WriteLine("Ievadiet trjstūra platumu.");

            string userplatums2 = Console.ReadLine();
            decimal platums2 = decimal.Parse(userplatums2);

            decimal laukums2 = garums2 + platums2 /2;
            Console.WriteLine("Trjstūra laukums ir" + " " + laukums2);

            //// 9. uzdevums

            Console.WriteLine("Ievadiet savu vecumu.");

            string userage2 = Console.ReadLine();

            Console.WriteLine("Sveiki," + " " + username + " " + "jūs esat" + " " + userage + " " + "gadus vecs." );

        }
    }
}
