namespace _MobilePhonePractice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Call
    {
        private DateTime dateAndTime;
        private string dialledPhoneNumber;
        private double callDuration;

        //Constructors
        public Call(DateTime dateNTime, string phoneNumber, double durationOfCall)
        {
            this.DateAndTime = dateNTime;
            this.DialledPhoneNumber = phoneNumber;
            this.CallDuration = durationOfCall;
        }

        // Properties
        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndTime;
            }
            private set
            {
                this.dateAndTime = value;
            }
        }

        public string DialledPhoneNumber
        {
            get
            {
                return this.dialledPhoneNumber;
            }
            private set
            {
                if (value.Length > 0 && value.Length < 17)
                {
                    this.dialledPhoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("Dialled phone number can not be less or zero digits and can not be more than twelve digits!");
                }
            }
        }

        public double CallDuration
        {
            get
            {
                return this.callDuration;
            }
            private set
            {
                if (value > 0)
                {
                    this.callDuration = value;
                }
                else
                {
                    throw new ArgumentException("The call duration can not be less then zero!");
                }
            }
        }

        public override string ToString()
        {
            StringBuilder callInfo = new StringBuilder();

            callInfo.AppendLine("---------> Call Info <---------");
            callInfo.AppendLine(string.Format("Date and time: {0}", this.DateAndTime));
            callInfo.AppendLine(string.Format("Dialled phone number: {0}", this.DialledPhoneNumber));
            callInfo.AppendLine(string.Format("Call duration: {0} seconds", this.CallDuration));

            return callInfo.ToString();
        }
    }
}
