using System;
using System.Collections.Generic;
using System.Text;

namespace Switch
{
    public class Switch
    {
        public Appliance Appliance;

        public SwitchStatus SwitchMode;

        public Switch(SwitchStatus switchMode)
        {
            this.SwitchMode = switchMode;
        }

        public void AddAppliance(Appliance appliance)
        {
            this.Appliance = appliance;
        }
    }
}
