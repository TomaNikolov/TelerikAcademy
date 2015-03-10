namespace Point3D
{
    using System;
    using System.IO;

    public class Point3DMain
    {
        static void Main()
        {
            Path path = new Path();
            path.PointSequence.Add(new Point3D(2, 3, 4));
            path.PointSequence.Add(new Point3D(2, 3, 4));
            path.PointSequence.Add(new Point3D(2, 3, 4));
            path.PointSequence.Add(new Point3D(2, 3, 4));
            PathStorage.Save(path);
            Path newPath = new Path();
            try
            {
                newPath.PointSequence = PathStorage.Load();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }


            foreach (var point in newPath.PointSequence)
            {
                Console.WriteLine(point);
            }

        }
    }
}
