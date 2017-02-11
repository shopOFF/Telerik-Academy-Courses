namespace _MobilePhonePractice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSMTest
    {
        private List<GSM> listOfMobilePhones = new List<GSM>()
        {
            new GSM("IPhone 3","Apple",150,"Gruio",new Battery(BatteryType.NiMH,23.4,11.1),new Display(4.3,120)),
            new GSM("Note 5","Samsung",1150,"John",new Battery(BatteryType.LiIon,43.4,21.1),new Display(5.7,12000)),
            new GSM("G5","LG",1050,"Atanas",new Battery(BatteryType.NiCd,53.7,31.5),new Display(5.5,22000))
         };
        public void DisplayGsmInfo()
        {
            foreach (var phone in listOfMobilePhones)
            {
                Console.WriteLine(phone);
            }
            Console.WriteLine(GSM.IPhone4s);
        }
    }
}
