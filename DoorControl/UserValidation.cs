using System;
using System.Collections.Generic;
using System.Text;

namespace DoorControl
{
    class UserValidation : IUserValidation
    {
        public bool ValidateEntryRequest(int ID)
        {
            if (ID >= 0 && ID <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
