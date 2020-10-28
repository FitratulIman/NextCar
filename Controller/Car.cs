using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Controller
{
    class Car
    {
        AccubatteryController accubatteryController;
        DoorController doorController;
        OnCarEngineStatusChanged callbackCarEngiinerStausChanged;

        public Car(AccubatteryController accubattery, DoorController doorController, OnCarEngineStatusChanged callbackCarEngineStatusChanged)
        {
            this.accubatteryController = accubatteryController;
            this.doorController = doorController;
            this.callbackCarEngiinerStausChanged = callbackCarEngiinerStausChanged;
        }

        public void turnOnPower()
        {
            this.accubatteryController.turnOn();
        }
        public void turnOfPower()
        {
            this.accubatteryController.turnOff();
        }

        public bool powerIsReady()
        {
            return this.accubatteryController.accubatteryIsOn();
        }

        public void closeTheDoor()
        {
            this.doorController.close();
        }
        public void openTheDoor()
        {
            this.doorController.open();
        }
        public void lockTheDoor()
        {
            this.doorController.activateLock();
        }
        public void unlockTheDoor()
        {
            this.doorController.open();
        }
        private bool doorIsClosed()
        {
            return this.doorController.isClose();
        }
        private bool doorIsLocked()
        {
            return this.doorController.isLocked();
        }
        public void toggleStartEngineButton()
        {
            if (!doorIsClosed())
            {
                this.callbackCarEngiinerStausChanged.carEngineStatusChanged("STOPPED", "door is open");
                return;
            }
            if (!doorIsLocked())
            {
                this.callbackCarEngiinerStausChanged.carEngineStatusChanged("STOPPED", "door is unlocked");
                return;
            }
            if (!powerIsReady())
            {
                this.callbackCarEngiinerStausChanged.carEngineStatusChanged("STOPPED", "no power available");
                return;
            }
            this.callbackCarEngiinerStausChanged.carEngineStatusChanged("STARTED", "Engine started");
        }
        public void toggleTheLoockDoorButton()
        {
            if (!doorIsLocked())
            {
                this.lockTheDoor();
            }
            else
            {
                this.unlockTheDoor();
            }
        }
        public void toggleTheDoorButton()
        {
            if (!doorIsClosed())
            {
                this.closeTheDoor();
            }
            else
            {
                this.openTheDoor();
            }
        }
        public void toggleThePowerButton()
        {
            if (!powerIsReady())
            {
                this.turnOnPower();
            }
        }
    }

    interface OnCarEngineStatusChanged
    {
        void carEngineStatusChanged(string value, string message);
    }
}
