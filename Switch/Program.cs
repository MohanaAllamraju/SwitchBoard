using System;
using System.Collections.Generic;
using System.Linq;

namespace Switch
{
    class Program
    {
        private static void displayBoards(BoardManager boardManager)
        {
            int index = 1;
            foreach (var board in boardManager.Boards)
                Console.WriteLine(index + ". Board " + index++);
        }

        private static void displaySwitches(BoardManager boardManager, int boardId)
        {
            int index = 1;
            foreach (var es in boardManager.Boards[boardId - 1].Switches)
            {
                Console.WriteLine(index + ". Switch - " + es.SwitchMode);
                index++;
            }
        }

        static void Main()
        {
            int noOfBoards = Extension.GetNumericUserValue("How many boards are there");
            
            BoardManager manager = new BoardManager(noOfBoards);
            
            while (true)
            {
                displayBoards(manager);
                int boardID = Extension.GetNumericUserValue("Choose a Board: ");
                displaySwitches(manager, boardID);

                Console.WriteLine("Press c to change the status : ");
                if (Console.ReadLine().Equals("c"))
                {
                    int switchID = Extension.GetNumericUserValue("Enter the switch:");
                    manager.Boards[boardID - 1].ChangeStatus(manager.Boards[boardID - 1].Switches[switchID - 1]);
                    displaySwitches(manager, boardID);
                    Console.WriteLine("Press e to exit : ");
                    if (Console.ReadLine().Equals("e"))
                    {
                        break;
                    }
                }
            }
        }
    }
}