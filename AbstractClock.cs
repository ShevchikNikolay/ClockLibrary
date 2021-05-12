using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace ClockLibrary
{
    /// <summary>
    /// Represents an abstract clock.
    /// </summary>
    public abstract class AbstractClock: IClock
    {
        private Timer timer;

        /// <summary>
        /// Gets or sets count of hours.
        /// </summary>
        public abstract int Hours { get; set; }

        /// <summary>
        /// Gets or sets count of minutes.
        /// </summary>
        public abstract int Minutes { get; set; }

        /// <summary>
        /// Gets or sets count of seconds.
        /// </summary>
        public abstract int Seconds { get; set; }
 
        /// <summary>
        /// Starts the clock.
        /// </summary>
        public void StartClock()
        {
            SetTick();
            timer.Start();
        }

        /// <summary>
        /// Stops the clock.
        /// </summary>
        public void StopClock()
        {
            timer.Stop();
            timer.Dispose();
        }

        private void SetTick()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += (sender, e) => OnTick();
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void OnTick()
        {
            Seconds++;
        }
    }
}
