using System;
using System.Collections.Generic;
using System.Text;

namespace DoorControl
{
    class DoorControl
    {
        public int ID { get; set; }
        public IUserValidation UserValidation;
        public IAlarm Alarm;
        public IDoor Door;
        public IEntryNotification EntryNotification;
        public bool Validation = false;

        public DoorControl(IUserValidation userValidation, IAlarm alarm, IDoor door, IEntryNotification entryNotification)
        {
            UserValidation = userValidation;
            Alarm = alarm;
            Door = door;
            EntryNotification = entryNotification;
        }

        public bool RequestEntry(int ID)
        {
            Validation = UserValidation.ValidateEntryRequest(ID);
            return Validation;
        }

        public void DoorOpened()
        {
            if (Validation == true)
            {
                Door.Open();
                EntryNotification.
                
                
            }
            else if (Validation == false)
            {

            }
        }

        public void DoorClosed()
        {
            
        }

    }
}
