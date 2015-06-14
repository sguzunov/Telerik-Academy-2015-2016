namespace Point
{
    using System;

    public struct Point3D 
    {
        private static readonly Point3D o; // problem 2

        public double X { get; set; }   // problem 1
        public double Y { get; set; }   // problem 1
        public double Z { get; set; }   // problem 1


        public Point3D(double x, double y, double z)
            : this() //problem 1
        {
           this.X = x;
           this.Y = y;
           this.Z = z;           
        }

        public static Point3D O  // problem 2
        {
            get
            {
               return new Point3D(0, 0, 0);
            } 
        }

        public override string ToString() // problem 1
        {
            return string.Format("Point({0};{1};{2})", this.X, this.Y, this.Z);
        }

    }
}
