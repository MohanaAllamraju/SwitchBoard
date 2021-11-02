using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Switch
{
    public static class Extension
    {
        public static int GetNumericUserValue(string consoleMessage = null)
        {
            string userInput;
            while (true)
            {
                Console.WriteLine(consoleMessage ?? "Please enter an number:");
                userInput = Console.ReadLine();
                if (String.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Your input is invalid");
                    continue;
                }
                break;
            }
            return (Convert.ToInt32(userInput));
        }
    }
}
