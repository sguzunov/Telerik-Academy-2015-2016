namespace Point
{
    using System;
    using System.Collections.Generic;

   public class Path
    {
        private List<Point3D> somePoints; //problem 4 

       public Path()
       {
           somePoints = new List<Point3D>();
       }        

        public List<Point3D> SomePoints // problem 4
        {
            get
            {
                return this.somePoints;
            }
            set
            {
                this.somePoints = value;
            }
        }

       
    }
}
