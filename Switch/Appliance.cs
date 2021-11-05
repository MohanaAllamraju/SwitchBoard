using System;
using System.Collections.Generic;
using System.Text;

namespace Switch
{

    public class Appliance
    {
        public  SwitchStatus SwitchStatus;
        public ApplianceType Type;
        public ApplianceStatus applianceStatus;
        public Appliance(SwitchStatus switchStatus)
        {
            this.SwitchStatus = switchStatus;
        }

        public Appliance(ApplianceType type)
        {
            this.Type = type;

        }
    }
}
