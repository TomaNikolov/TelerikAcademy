namespace VersionAttribute
{
    using System;

    [Version("2.11")]
    class VersionAtributeTests
    {
        static void Main()
        {
            var attribute = typeof(VersionAtributeTests).GetCustomAttributesData();
            Console.WriteLine(attribute[0]);
        }
    }
}
