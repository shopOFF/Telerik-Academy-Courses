namespace _MobilePhonePractice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Display
    {
        private double sizeOfDisplay;  // Task 1
        private int numberOfColors;  // Task 1

        public Display(double size, int colors)
        {
            this.SizeOfDisplay = size;
            this.NumberOfColors = colors;
        }

        //Properties:  // Task 5
        public double SizeOfDisplay
        {
            get
            {
                return this.sizeOfDisplay;
            }
            set
            {
                if (value > 0)
                {
                    this.sizeOfDisplay = value;
                }
                else
                {
                    throw new ArgumentException("The display of the device can not be less or equal to zero!");
                }
            }
        }
        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value>0)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new ArgumentException("The display colors of the device con not be less or equal to zero!");
                }
            }
        }
        public override string ToString()
        {
            StringBuilder displayInfo = new StringBuilder();

            displayInfo.AppendLine("-------Display Info-------");
            displayInfo.AppendLine(string.Format("Display size: {0}", this.SizeOfDisplay));
            displayInfo.AppendLine(string.Format("Display number of colors: {0}", this.NumberOfColors));

            return displayInfo.ToString();
        }
    }
}
