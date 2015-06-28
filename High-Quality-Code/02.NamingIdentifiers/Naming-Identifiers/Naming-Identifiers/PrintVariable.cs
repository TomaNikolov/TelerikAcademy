namespace Naming_Identifiers
{
    class PrintVariable
    {
        static void Main()
        {
            var printer = new Printer.BoolPrint();
            printer.Print(false);
            printer.Print(true);
        }
    }
}
