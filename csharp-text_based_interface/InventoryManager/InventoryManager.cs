using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class Program
    {
        static bool userHasBeenWelcomed = false;

        static void Main(){
            while(true){
                //Load objects
                //Provide system output
                Console.WriteLine(SystemOutput());
                var input = Console.ReadLine();
                ProcessInput(input);
            }
        }

        static string SystemOutput(){
            if(userHasBeenWelcomed){
                return "Enter in a command (use 'ClassNames' to list available commands):";
            }
            else{
                userHasBeenWelcomed = true;
                return "Welcome to the world's best inventory manager! To begin enter in a command (use 'ClassNames' to list available commands):";
            }
        }

        static void ProcessInput(string input){
            switch (input){
                case "exit":
                    Console.WriteLine("Goodbye!");
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Command '" + input + "' is not a known command.");
                    break;
            }
        }
    }
}