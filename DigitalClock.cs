namespace ClockLibrary
{
    /// <summary>
    /// Represents an digital clock.
    /// </summary>
    class DigitalClock : AbstractClock
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        /// <summary>
        /// Gets or sets count of hours.
        /// </summary>
        public override int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                _hours = value % 24;
            }
        }

        /// <summary>
        /// Gets or sets count of minutes.
        /// </summary>
        public override int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value > 59)
                {
                    Hours += (int)(value / 60);
                    _minutes = value % 60;
                }
                else
                {
                    _minutes = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets count of seconds.
        /// </summary>
        public override int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (value > 59)
                {
                    Minutes += (int)(value / 60);
                    _seconds = value % 60;
                }
                else
                {
                    _seconds = value;
                }
            }
        }
    }
}
