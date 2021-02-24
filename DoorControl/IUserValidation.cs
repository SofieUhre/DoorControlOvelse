using System;
using System.Collections.Generic;
using System.Text;

namespace DoorControl
{
    interface IUserValidation
    {
        public bool ValidateEntryRequest(int ID);
    }
}
