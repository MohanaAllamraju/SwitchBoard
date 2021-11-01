using System;
using System.Collections.Generic;
using System.Text;

namespace Switch
{
    public class Switch
    {
        public Appliance Appliance;
        public SwitchStatus SwitchMode;


        public Switch(Appliance appliance, SwitchStatus switchMode)
        {
            this.Appliance = appliance;
            this.SwitchMode = switchMode;

        }
    }
}
