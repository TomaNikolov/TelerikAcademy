namespace MobilePhoneInfo
{
    using System;

    public class GSMCallHistoryTest
    {
        public static void AddCalls(GSM gsm)
        {
            gsm.AddCal(new Call("0882323436", 74));
            gsm.AddCal(new Call("0882323437", 23));
            gsm.AddCal(new Call("0882323438", 555));
            gsm.AddCal(new Call("0882323439", 23));
            gsm.AddCal(new Call("0882323436", 545));
            gsm.AddCal(new Call("0882323446", 2));
            gsm.AddCal(new Call("0882323457", 34));
            gsm.AddCal(new Call("0882323468", 54));
            gsm.AddCal(new Call("0882323436", 12));
        }

        public static void CallsInfo(GSM gsm)
        {
            foreach (var call in gsm.Calls)
            {
                Console.WriteLine("*****New call*****");
                Console.WriteLine(call);
            }
        }

        public static void PrintTotalPrice(GSM gsm, double price)
        {

            Console.WriteLine("Total price is: {0}", gsm.CallPrice(price));
        }

        public static void RemoveLongestCall(GSM gsm)
        {
            const int start = 0;

            long longestCall = start;
            int index = start;

            for (int i = start; i < gsm.Calls.Count; i++)
			{
                if (gsm.Calls[i].DurationInSecond > longestCall)
                {
                    longestCall = gsm.Calls[i].DurationInSecond;
                    index = i;
                }
			}
            gsm.DeleteCall(index);
        }
    }
}
