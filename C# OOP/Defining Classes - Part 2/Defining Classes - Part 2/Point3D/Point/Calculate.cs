namespace Point
{
    using System;
   
    public static class Calculate
    {
        public static double CalculateDistnce(Point3D firstPoint, Point3D secondPoint)
        {

            double distance = Math.Sqrt((secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X) +
                                 (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y) +
                                 (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z));

            return distance;
        }

    }
}
