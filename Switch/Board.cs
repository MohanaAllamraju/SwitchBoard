using System;
using System.Collections.Generic;
using System.Text;

namespace Switch
{
    public class Board
    {
        public List<Switch> Switches = new List<Switch>();
        Appliance appliance;
        public Board(int noOfSwitches)
        {
            for (int i = 0; i < noOfSwitches; i++)
                this.Switches.Add(new Switch(appliance, SwitchStatus.Off));
        }

        public void ChangeStatus(Switch eSwitch)
        {
            if (eSwitch.SwitchMode == SwitchStatus.Off)
            {
                eSwitch.SwitchMode = SwitchStatus.On;
            }
            else
                eSwitch.SwitchMode = SwitchStatus.Off;
        }
    }
}
