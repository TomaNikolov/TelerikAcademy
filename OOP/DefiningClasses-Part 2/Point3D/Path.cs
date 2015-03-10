namespace Point3D
{
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        public Path()
        {
            this.PointSequence = new List<Point3D>();
        }

        public List<Point3D> PointSequence { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var point in this.PointSequence)
            {
                result.AppendLine(point.X + " " + point.Y + " " + point.Z);
            }
            return result.ToString();
        }
    }
}
