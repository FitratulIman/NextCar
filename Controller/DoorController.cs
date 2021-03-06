﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNextCar.Model;

namespace WpfApp1.Controller
{
    class DoorController
    {
        private Door door;
        private OnDoorChanged onDoorChanged;

        public DoorController(OnDoorChanged onDoorChanged)
        {
            this.door = new Door();
            this.onDoorChanged = onDoorChanged;
        }

        public void close()
        {
            this.door.close();
            this.onDoorChanged.doorStatusChanged("CLOSE", "door is closed");
        }

        public void open()
        {
            this.door.open();
            this.onDoorChanged.doorStatusChanged("OPENED", "door is opened");
        }

        public void activateLock()
        {
            if (this.door.isClosed())
            {
                this.door.activateLock();
                onDoorChanged.doorSecurityChanged("LOCKED", "door is locked");
            }
            else
            {
                unlock();
            }
        }

        private void unlock()
        {
            this.door.unlock();
            onDoorChanged.doorSecurityChanged("UNLOCKED", "door is unlocked");
        }
        public bool isClose()
        {
            return this.door.isClosed();
        }
        public bool isLocked()
        {
            return this.door.isLocked();
        }
    }

    interface OnDoorChanged
    {
        void doorSecurityChanged(string vale, string message);
        void doorStatusChanged(string vale, string message);
    }
}
