/*
 * Author: Jessica Beckford 
 * Date 2/4/2021
 */ 
using System;

namespace D3_MethodsJB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");

            try 
            {
                String input = Console.ReadLine();
              
                String greeting_student = Greeting(input);
            }
            catch
            {
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
            
        } // End of main method 

        private static string Greeting(string input)
        {
            String name = input;
            Console.WriteLine("Hello " + name + "!!");
            return name;
        }
    }
}
