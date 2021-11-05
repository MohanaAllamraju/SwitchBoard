using System;
using System.Collections.Generic;
using System.Text;

namespace Switch
{
    public class Board
    {
        public List<Switch> Switches = new List<Switch>();

        public Board(int noOfSwitches)
        {
            for (int i = 0; i < noOfSwitches; i++)
                this.Switches.Add(new Switch(SwitchStatus.Off));
        }

        public void ChangeStatus(Switch eSwitch)
        {
            eSwitch.SwitchMode = (eSwitch.SwitchMode == SwitchStatus.Off ? SwitchStatus.On : SwitchStatus.Off);
            eSwitch.Appliance.SwitchStatus = (eSwitch.SwitchMode == SwitchStatus.Off ? SwitchStatus.On : SwitchStatus.Off);
            eSwitch.Appliance.applianceStatus = (eSwitch.Appliance.applianceStatus == ApplianceStatus.Off ? ApplianceStatus.On : ApplianceStatus.Off);
        }

    }
}
