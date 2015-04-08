namespace Point3D
{
    using System.Text;

    // Problem 1. Structure
    public struct Point3D
    {
        private static readonly Point3D o = new Point3D(0, 0, 0);

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x, int y, int z)
            :this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D O
        {
            get
            {
                return o;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("X = {0}; Y = {1}; Z = {2};", this.X, this.Y, this.Z);
            return result.ToString();
        }
    }
}
