namespace MobilePhoneInfo
{
    using System;

   public class MPIMain
    {
        static void Main()
        {
            const double pricePerMinute = 0.37;

            //Problem 7. GSM test
            Console.WriteLine("***** GSM test*****");
            GSM[] gsmArray = GSMTest.GsmCreator();
            GSMTest.PrintGsm(gsmArray);
            GSMTest.Iphone4sInfo();

            //Problem 12. Call history test
            Console.WriteLine("***** Call history test *****");
            var gsm = new GSM("Samsung", "Galaxy SIII", 370, "Pesho",
                     new Battery("A1349", 200, 2, BatteryType.NiCd),
                         new Display(4.3, 16000000));
            GSMCallHistoryTest.AddCalls(gsm);
            GSMCallHistoryTest.CallsInfo(gsm);
            GSMCallHistoryTest.PrintTotalPrice(gsm, pricePerMinute);
            GSMCallHistoryTest.RemoveLongestCall(gsm);
            GSMCallHistoryTest.PrintTotalPrice(gsm, pricePerMinute);
            gsm.ClearCallHistory();
            GSMCallHistoryTest.CallsInfo(gsm);
        }
    }
}
