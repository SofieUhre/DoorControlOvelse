using System;
using System.Collections.Generic;
using System.Text;

namespace DoorControl
{
    class Door : IDoor
    {
        public void Open()
        {
            Console.WriteLine("The door is open");
        }

        public void Closed()
        {
            Console.WriteLine("The door is closed");
        }
    }
}
