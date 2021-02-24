using System;
using System.Collections.Generic;
using System.Text;

namespace DoorControl
{
    class Alarm : IAlarm
    {
        public void RaiseAlarm()
        {
            Console.WriteLine("ALARM!!");
        }
    }
}
