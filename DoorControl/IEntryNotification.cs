using System;
using System.Collections.Generic;
using System.Text;

namespace DoorControl
{
    interface IEntryNotification
    {
        public void NotifyEntryGranted(int ID);
        public void NotifyEntryDenied(int ID);
    }
}
