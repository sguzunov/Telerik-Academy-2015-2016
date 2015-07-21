namespace CohesionAndCoupling
{
    using System;

    public static class GeometryUtils
    {
        private static readonly string INVALID_WIDTH_EXCEPTION = "Width must be a number bigger than 0.";
        private static readonly string INVALID_HEIGHT_EXCEPTION = "Height must be a number bigger than 0.";
        private static readonly string INVALID_DEPTH_EXCEPTION = "Depth must be a number bigger than 0.";

        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        public static double CalcVolume(double width, double height, double depth)
        {
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException(GeometryUtils.INVALID_WIDTH_EXCEPTION);
            }

            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException(GeometryUtils.INVALID_HEIGHT_EXCEPTION);
            }

            if (depth <= 0)
            {
                throw new ArgumentOutOfRangeException(GeometryUtils.INVALID_DEPTH_EXCEPTION);
            }

            double volume = width * height * depth;
            return volume;
        }

        public static double CalcDiagonalXY(double width, double height, double depth)
        {
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException(GeometryUtils.INVALID_WIDTH_EXCEPTION);
            }

            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException(GeometryUtils.INVALID_HEIGHT_EXCEPTION);
            }

            if (depth <= 0)
            {
                throw new ArgumentOutOfRangeException(GeometryUtils.INVALID_DEPTH_EXCEPTION);
            }

            double distance = CalcDistance3D(0, 0, 0, width, height, depth);
            return distance;
        }

        public static double CalcDiagonalXY(double width, double height)
        {
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException(GeometryUtils.INVALID_WIDTH_EXCEPTION);
            }

            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException(GeometryUtils.INVALID_HEIGHT_EXCEPTION);
            }

            double distance = CalcDistance2D(0, 0, width, height);
            return distance;
        }

        public static double CalcDiagonalXZ(double width, double depth)
        {
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException(GeometryUtils.INVALID_WIDTH_EXCEPTION);
            }

            if (depth <= 0)
            {
                throw new ArgumentOutOfRangeException(GeometryUtils.INVALID_DEPTH_EXCEPTION);
            }

            double distance = CalcDistance2D(0, 0, width, depth);
            return distance;
        }

        public static double CalcDiagonalYZ(double height, double depth)
        {
            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException(GeometryUtils.INVALID_HEIGHT_EXCEPTION);
            }

            if (depth <= 0)
            {
                throw new ArgumentOutOfRangeException(GeometryUtils.INVALID_DEPTH_EXCEPTION);
            }

            double distance = CalcDistance2D(0, 0, height, depth);
            return distance;
        }
    }
}
