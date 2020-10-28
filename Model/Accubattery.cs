using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNextCar.Model
{
    class Accubattery
    {
        private int voltage;
        private bool stateOn = false;

        public Accubattery(int voltage)
        {
            this.voltage = voltage;
        }
        
        public void tunOn()
        {
            this.stateOn = true;
        }

        public void turnOff()
        {
            this.stateOn = false;
        }

        public bool isOn()
        {
            return this.stateOn;
        }

        internal void turnOn()
        {
            throw new NotImplementedException();
        }

        internal void trunOff()
        {
            throw new NotImplementedException();
        }
    }
}
