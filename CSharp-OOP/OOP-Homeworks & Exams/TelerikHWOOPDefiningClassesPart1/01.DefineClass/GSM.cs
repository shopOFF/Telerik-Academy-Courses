namespace _MobilePhonePractice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        #region Fields

        public static GSM IPhone4s = new GSM("IPhone 4", "Apple", 450, "Nikodim", new Battery(BatteryType.LiIon, 25, 15), new Display(5, 16000));

        private string phoneModel;  // Task 1
        private string phoneManufacturer;   // Task 1
        private decimal phonePrice;     // Task 1
        private string phoneOwner;  // Task 1
        private Battery battery;    // Task 1
        private Display display;    // Task 1
        private List<Call> callHistory;     // Task 9

        #endregion

        #region Constructors

        // Constructors: 
        public GSM(string model, string manufacturer)  // Task 2
        {
            this.PhoneModel = model;
            this.PhoneManufacturer = manufacturer;
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal price)    // Task 2
            : this(model, manufacturer)
        {
            this.PhonePrice = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)  // Task 2
            : this(model, manufacturer, price)
        {
            this.PhoneOwner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)    // Task 2
            : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
            this.Display = display;
        }

        #endregion

        #region Properties

        //Properties:  // Task 5
        public string PhoneModel
        {
            get
            {
                return this.phoneModel;
            }
            set
            {
                if (value != string.Empty && value != null)
                {
                    this.phoneModel = value;
                }
                else
                {
                    throw new ArgumentException("The phone model can not be empty!");
                }
            }
        }

        public string PhoneManufacturer
        {
            get
            {
                return this.phoneManufacturer;
            }
            set
            {
                if (value != string.Empty && value != null)
                {
                    this.phoneManufacturer = value;
                }
                else
                {
                    throw new ArgumentException("The phone manufacturer can not be empty!");
                }
            }
        }
        public decimal PhonePrice
        {
            get
            {
                return this.phonePrice;
            }
            set
            {
                if (value > 0)
                {
                    this.phonePrice = value;
                }
                else
                {
                    throw new ArgumentException("The phone price can not be less or equal to zero!");
                }
            }
        }
        public string PhoneOwner
        {
            get
            {
                return this.phoneOwner;
            }
            set
            {
                if (value != string.Empty && value != null)
                {
                    this.phoneOwner = value;
                }
                else
                {
                    throw new ArgumentException("The phone owner can not be empty!");
                }
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory   // Task 9
        {
            get
            {
                return this.callHistory;
            }
            private set
            {
                this.callHistory = value;
            }
        }

        #endregion

        #region Methods

        //Methods

        public void AddCall(Call call)     // Task 10
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call)   // Task 10
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()      // Task 10
        {
            this.CallHistory.Clear();
        }


        public decimal TotalPriceOfCalls(decimal pricePerMinute)      // Task 11
        {
            double durationOfAllCalls = 0;
            decimal totalPrice = 0;
            foreach (var call in CallHistory)
            {
                durationOfAllCalls += call.CallDuration;
            }
            return totalPrice = (decimal)(durationOfAllCalls / 60) * pricePerMinute;
        }

        public override string ToString()      //Task 4
        {
            StringBuilder deviceInfo = new StringBuilder();

            deviceInfo.AppendLine("---------Mobile Device Info---------");
            deviceInfo.AppendLine(string.Format("Model: {0}", this.PhoneModel));
            deviceInfo.AppendLine(string.Format("Manufacturer: {0}", this.PhoneManufacturer));
            deviceInfo.AppendLine(string.Format("Price: {0}", this.PhonePrice));
            deviceInfo.AppendLine(string.Format("Owner: {0}", this.PhoneOwner));
            deviceInfo.AppendLine(string.Format("{0}", this.Battery.ToString()));
            deviceInfo.Append(string.Format("{0}", this.Display.ToString()));

            return deviceInfo.ToString();
        }

        #endregion
    }
}