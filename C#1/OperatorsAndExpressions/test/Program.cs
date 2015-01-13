using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchangeAdvanced
{
    class Program
    {
       static  uint number;
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            number = uint.Parse(Console.ReadLine());

            Console.Write("Enter a position p: ");
            int  positionP = int.Parse(Console.ReadLine());

            Console.Write("Enter a position q: ");
            int positionQ = int.Parse(Console.ReadLine());

            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());

            uint [] bitArryP = new uint [k];
            uint[] bitArryQ = new uint[k];

            for (int i = positionP, l= positionQ, j = 0; i < (positionP + k) ; j++, i++, l++)
            {
                bitArryP[j] = ZeroOrOne(i);
                bitArryQ[j] = ZeroOrOne(l);
            }

            //The second loop is to avoid the incorrect bits of the overlap
            for (int i = positionQ, l = positionP, j = 0 ; i < positionQ + k; j++, i++, l++)
            {
                ChangeBit(i, bitArryP[j]);
                ChangeBit(l, bitArryQ[j]);

            }

            Console.WriteLine(number);
        }

        private static void ChangeBit(int bitPosition, uint result)
        {
            uint mask;

            if (result == 0)
            {
                mask = (uint)1 << bitPosition;
                number &= ~ mask;
            }
            else
            {
                mask = (uint)1 << bitPosition;
                number |= mask;
            }
        }
        private static uint ZeroOrOne(int position)
        {
            uint mask = (uint)1 << position;
            uint maskAndNumber = number & mask;
            uint result = maskAndNumber >> position;

            return result;

        }
    }
}