namespace MobilePhoneInfo
{
    using System;
    using System.Text;

   public class Display
    {
       private double? size;
       private int? numberOfColors;
       
       public Display()
       {

       }

       public Display(double size, int numberOfColors)
       {
           this.Size = size;
           this.NumberOfColors = numberOfColors;
       }

       public double? Size
       {
           get
           {
               return this.size;
           }
          private set
           {
               if (value < 0 || value > double.MaxValue)
               {
                   throw new ArgumentOutOfRangeException();
               }
               this.size = value;
           }
       }

       public int? NumberOfColors
       {
           get
           {
               return this.numberOfColors;
           }
           private set
           {
               if (value < 0 || value > int.MaxValue)
               {
                   throw new ArgumentOutOfRangeException();
               }
               this.numberOfColors = value;
           }
       }

       public override string ToString()
       {
           StringBuilder result = new StringBuilder();
           result.AppendFormat("Size: {0}; Numbers of Colors: {1}", this.Size, this.NumberOfColors);
           return result.ToString();
       }
    }
}
