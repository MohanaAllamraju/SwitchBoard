using System;
using System.Collections.Generic;
using System.Text;

namespace Switch
{

    public class Appliance
    {
        int SwitchID;
        SwitchStatus SwitchStatus;
       public Appliance(int switchID, SwitchStatus switchStatus)
        {
            this.SwitchID = switchID;
            this.SwitchStatus = switchStatus;
        }
    }
}
