using System;
using System.Collections.Generic;
using System.Text;

namespace ClockLibrary
{
    interface IClock
    {
        int Hours { get; set; }
        int Minutes { get; set; }
        int Seconds { get; set; }

        void StartClock();
        void StopClock();
    }
}
