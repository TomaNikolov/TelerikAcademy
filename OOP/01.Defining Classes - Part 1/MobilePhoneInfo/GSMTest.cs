namespace MobilePhoneInfo
{
    using System;

    //Problem 7. GSM test
    public static class GSMTest
    {
        //Create an array of few instances of the GSM class.
        public static GSM[] GsmCreator()
        {
            GSM[] result = new GSM[]{
               new GSM("Samsung", "Galaxy SIII", 370, "Pesho",
                   new Battery("A1349", 200, 2, BatteryType.NiCd ),
                       new  Display(4.3, 16000000)),
              new GSM("Lenovo", "S920", 470, "Gosho",
                   new Battery("A1339", 200, 2, BatteryType.LiIon ),
                       new  Display(4.3, 16000000)),
              new GSM("HTC", "HD2", 270, "Vankata",
                   new Battery("A1349", 200, 2, BatteryType.NiMX ),
                       new  Display(4.3, 16000000)),
                              };
            return result;
        }

        // Display the information about the GSMs in the array.
        public static void PrintGsm(GSM[] gsmArray)
        {
            foreach (var gsm in gsmArray)
            {
                Console.WriteLine("*****{0}*****", gsm.Manufacturer);
                Console.WriteLine(gsm);
            }
        }

        //Display the information about the static property IPhone4S.
        public static void Iphone4sInfo()
        {
            Console.WriteLine("*****{0}*****", GSM.IPhone4S.Manufacturer);
            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}