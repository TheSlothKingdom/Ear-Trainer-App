using System;
using NetCoreAudio;

namespace Ear_Trainer_App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shoudILoop = true;
            while (shoudILoop) 
            {
                Console.WriteLine("Hello, where would you like to go?\nPress 'Q' and 'Enter' for quiz\nPress 'L' and 'Enter' for library\nPress 'E' and 'Enter' to exit");
                string navigationStart = Console.ReadLine().ToLower();

                if (navigationStart == "q")
                {

                }
                else if (navigationStart == "l")
                {
                    
       
                }
                else if (navigationStart == "e")
                {
                    shoudILoop = false;
                }
                else
                {
                    Console.WriteLine("please enter a valid key");
                }
            }   
        }
    }
}
