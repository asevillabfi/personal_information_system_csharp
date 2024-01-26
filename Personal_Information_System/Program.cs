using System;
using static System.Net.Mime.MediaTypeNames;

namespace PersonalInformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
     
            // Loop the function until you are done 🚀🚀🚀
            do
            {
                if (!program.start())
                {
                    break;
                }
            } while (true);
        }

        bool start ()
        {
            // Declare constant variable first 👇
            const int LEGAL_DRINKING_AGE = 21;

            // Declare constant variable first 👇
            string name;
            int age;
            double height;

            // Declare constant variable first 👇
            string personalInfo;

            Console.WriteLine("Personal Information System\n");

            // Name input
            do
            {
                Console.Write("Please enter your Name: ");
                var iname = Console.ReadLine();
                
                // correct input
                if (!string.IsNullOrEmpty(iname))
                {
                    name = iname;
                    break;
                }

                // null input
                Console.WriteLine("Required Field! Do not skip");
                continue;

            } while (true);

            // Age input
            do
            {
                Console.Write("Please enter your Age: ");
                var iage = Console.ReadLine();

                // null input
                if (string.IsNullOrEmpty(iage)) {
                    Console.WriteLine("Required Field! Do not skip");
                        continue; 
                };                

                // correct input
                if (int.TryParse(iage, out int ageN))
                {
                    // negative input
                    if (ageN < 0)
                    {
                        Console.WriteLine("Negative Value! Try again");
                        continue;
                    }
                    age = ageN;
                    break;
                }

                // input letters instead of numbers
                Console.WriteLine("Wrong Format");
            } while (true);

            // Height input
            do
            {
                Console.Write("Please enter your Height (m): ");
                var iheight = Console.ReadLine();

                // null input
                if (string.IsNullOrEmpty(iheight))
                {
                    Console.WriteLine("Required Field! Do not skip");
                    continue;
                };

                // correct input
                if (double.TryParse(iheight, out double heightN))
                {
                    // negative input
                    if (heightN < 0)
                    {
                        Console.WriteLine("Negative Value! Try again");
                        continue;
                    }
                    height = heightN;
                    break;
                }

                // input letters instead of numbers
                Console.WriteLine("Wrong Format");

            } while (true);

            Console.WriteLine("\n------------------------------------------------\n");

            // Show inputted information
            personalInfo = "Name: " + name + "\n" + "Age: " + age + "\n" + "Height: " + height + " meters";
            Console.WriteLine(personalInfo);

            // Check age for legal drinking
            if (height < LEGAL_DRINKING_AGE)
            {
                Console.Write("\nSorry, you are underage for drinking\n");
            } else
            {
                Console.Write("\nYou are legally allowed to drink.\n");
            }

            Console.WriteLine("\n------------------------------------------------\n");

            // Re-do again
            Console.Write("Do you still want to continue? (Hit enter to exit OR Type Y to continue): ");
            var doContinue = Console.ReadLine();

            if (string.IsNullOrEmpty(doContinue)) return false;

            Console.WriteLine("\n");
            return true;
        }
    }
}