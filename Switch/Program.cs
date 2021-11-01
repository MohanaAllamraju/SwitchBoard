using System;
using System.Collections.Generic;
using System.Linq;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many boards are there");
            int noOfBoards = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many switches are there");
            int noOfSwitches = Convert.ToInt32(Console.ReadLine());
            BoardManager manager = new BoardManager(noOfBoards, noOfSwitches);
            while(true)
            {
                
                Console.WriteLine("Choose a Board : ");
                int index = 1;
                foreach(var board in manager.Boards)
                {
                    Console.WriteLine(index + ". Board " + index++);
                }
                int boardID = Convert.ToInt32(Console.ReadLine());

                index = 1;
                foreach(var es in manager.Boards[boardID-1].Switches)
                {
                    Console.WriteLine(index + ". Switch - " + es.SwitchMode);
                    index++;
                }
                Console.WriteLine("Enter the switch: ");
                int switchID = Convert.ToInt32(Console.ReadLine());
                manager.Boards[boardID-1].ChangeStatus(manager.Boards[boardID-1].Switches[switchID-1]);
                index = 1;
                foreach (var es in manager.Boards[boardID-1].Switches)
                {
                    Console.WriteLine(index + ". Switch - " + es.SwitchMode);
                    index++;
                }

                Console.WriteLine("Press e to exit : ");
                if (Console.ReadLine().Equals("e"))
                {
                    break;
                }

            }



        }

    }
}
