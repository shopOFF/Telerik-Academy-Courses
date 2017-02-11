namespace _MobilePhonePractice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Battery
    {
        private BatteryType batteryModel; // Task 3

        private double batteryHoursIdle; // Task 1

        private double batteryHoursTalk; // Task 1

        public Battery(BatteryType model, double idleTime, double talkTime)   // Task 2
        {
            this.BatteryModel = model;
            this.BatteryHoursIdle = idleTime;
            this.BatteryHoursTalk = talkTime;
        }

        //Properties:  // Task 5
        public BatteryType BatteryModel
        {
            get
            {
                return this.batteryModel;
            }

            set
            {
                this.batteryModel = value;
            }
        }

        public double BatteryHoursIdle
        {
            get
            {
                return this.batteryHoursIdle;
            }
            set
            {
                if (value > 0)
                {
                    this.batteryHoursIdle = value;
                }
                else
                {
                    throw new ArgumentException("Battery hours idle can not be less or equal to zero!");
                }
            }
        }

        public double BatteryHoursTalk
        {
            get
            {
                return this.batteryHoursTalk;
            }

            set
            {
                if (value > 0)
                {
                    this.batteryHoursTalk = value;
                }
                else
                {
                    throw new ArgumentException("Battery hours talk can not be less or equal to zero!");
                }
            }
        }
        public override string ToString()
        {
            StringBuilder batteryInfo = new StringBuilder();

            batteryInfo.AppendLine("-------Battery Info-------");
            batteryInfo.AppendLine(string.Format("Model: {0}", this.BatteryModel));
            batteryInfo.AppendLine(string.Format("Battery hours idle: {0}", this.BatteryHoursIdle));
            batteryInfo.AppendLine(string.Format("Battery hours talk: {0}", this.BatteryHoursTalk));

            return batteryInfo.ToString().Trim('\n');
        }
    }
}
