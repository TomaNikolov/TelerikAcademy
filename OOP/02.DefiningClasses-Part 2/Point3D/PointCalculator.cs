namespace Point3D
{
    using System;

    public static class PointCalculator
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPint)
        {
            double distanceBetweenX = Math.Pow((firstPoint.X - secondPint.X), 2);
            double distanceBetweenY = Math.Pow((firstPoint.Y - secondPint.Y), 2);
            double distanceBetweenZ = Math.Pow((firstPoint.Z - secondPint.Z), 2);

            double distance = Math.Sqrt(distanceBetweenX + distanceBetweenY + distanceBetweenZ);

            return distance;
        }
    }
}
