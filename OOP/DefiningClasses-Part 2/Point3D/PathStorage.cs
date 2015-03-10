namespace Point3D
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void Save(Path path)
        {
            const string filePath = "save.txt";
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {

                    streamWriter.Write(path);

                }
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("You dont have permission.Call you system administrator for help!");
            }
        }
        // On every line in file have a integer with one white space between them.
        // Using linq to split and parse in array of int. Then add new Point3D with the array value.
        public static System.Collections.Generic.List<Point3D> Load()
        {
            const string filePath = "save.txt";
            List<Point3D> result = new List<Point3D>();
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string line = streamReader.ReadLine();
                while (line != null)
                {
                    var splitLine = line.Split(new[]{" "}, StringSplitOptions.RemoveEmptyEntries )
                                                  .Select(x => int.Parse(x)).ToArray();
                    result.Add(new Point3D(splitLine[0], splitLine[1], splitLine[2]));
                    line = streamReader.ReadLine();
                }
            }
            return result;
        }


    }
}
