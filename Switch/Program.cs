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
                Console.Write(index + ". Switch - " + es.SwitchMode);
                if(es.Appliance != null)
                {
                    Console.Write("\t - " + es.Appliance.Type + " appliance connected.The status of appliance is :  " + es.Appliance.applianceStatus + "\n");
                } else
                {
                    Console.Write("\t - No appliance conncted\n");
                }
                index++;
            }
        }

        static void Main()
        {
            int noOfBoards = Extension.GetNumericUserValue("How many boards are there");
            List<Appliance> appliances = new List<Appliance>();
            appliances.Add(new Appliance(ApplianceType.TV));
            appliances.Add(new Appliance(ApplianceType.AC));
            appliances.Add(new Appliance(ApplianceType.FAN));
            appliances.Add(new Appliance(ApplianceType.LIGHT));

            BoardManager manager = new BoardManager(noOfBoards);
            
            while (true)
            {
                displayBoards(manager);
                int boardID = Extension.GetNumericUserValue("Choose a Board: ");
                int menuOption = Extension.GetNumericUserValue("Select an option :  \n 1.Show Switches \n 2.Add Appliance");
                displaySwitches(manager, boardID);
                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("Press c to change the status : ");
                        if (Console.ReadLine().Equals("c"))
                        {
                            int switchID = Extension.GetNumericUserValue("Enter the switch:");
                            manager.Boards[boardID - 1].ChangeStatus(manager.Boards[boardID - 1].Switches[switchID - 1]);
                            displaySwitches(manager, boardID);
                        }
                        break;
                    case 2:
                        int switchid = Extension.GetNumericUserValue("Enter the switch:");
                        int index = 1;
                        foreach (var name in Enum.GetNames(typeof(ApplianceType)))
                        {
                            Console.WriteLine(index++ + ". " + name);
                        }
                        int applianceType = Extension.GetNumericUserValue("Select the appliance type:");
                        var switchInfo = manager.Boards[boardID - 1].Switches[switchid - 1];
                        var appliance = appliances.Find(a => a.Type == (ApplianceType)applianceType - 1);
                        switchInfo.AddAppliance(appliance);
                        break;

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