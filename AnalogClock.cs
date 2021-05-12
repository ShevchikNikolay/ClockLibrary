namespace ClockLibrary
{
    /// <summary>
    /// Represents an analog clock.
    /// </summary>
    class AnalogClock : AbstractClock
    {
        /// <summary>
        /// Count of degrees in one hour;
        /// </summary>
        public const int DegInAnHour = 30;

        /// <summary>
        /// Count of degrees in one minute or one second.
        /// </summary>
        public const int DegInAnMinuteSecond = 6;

        private int _hours;
        private int _minutes;
        private int _seconds;

        /// <summary>
        /// Sets count of hours and gets turn of hour hand in degrees.
        /// </summary>
        public override int Hours
        {
            get
            {
                return _hours * DegInAnHour;
            }
            set
            {
                _hours = value % 24;
            }
        }

        /// <summary>
        /// Sets count of minutes and gets turn of minute hand in degrees.
        /// </summary>
        public override int Minutes
        {
            get
            {
                return _minutes * DegInAnMinuteSecond;
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
        /// Sets count of seconds and gets turn of second hand in degrees.
        /// </summary>
        public override int Seconds
        {
            get
            {
                return _seconds * DegInAnMinuteSecond;
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
