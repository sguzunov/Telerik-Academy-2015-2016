namespace Point
{
    using System;
    using System.IO;
    using System.Text;

    public static class PathStorage // problem 4
    {
        public static void SavePaths(Path path) // writing points in a text file
        {
            using (StreamWriter sw = new StreamWriter(@"PathStorage.txt"))
            {
                for (int i = 0; i < path.SomePoints.Count; i++)
                {
                    sw.WriteLine(path.SomePoints[i]);
                } 
            }                                
        }


       public static Path LoadPath(string pathToFile) // writing points in a text file
       {
           Path currentPath = new Path();
           string line=string.Empty;
           double x = 0, y = 0, z = 0;
           StringBuilder currentNumber = new StringBuilder();
           int count = 0;

           using (StreamReader sr = new StreamReader(pathToFile))
           {
  
               while ((line = sr.ReadLine()) != null)
               {                   
                   for (int i = 6; i < line.Length; i++)
                   {
                       if (!(char.IsDigit(line[i]) || line[i] == ','))
                       {
                           if (count == 0)
                           {
                               x = double.Parse(currentNumber.ToString());
                               currentNumber.Clear();
                           }
                           if (count == 1)
                           {
                               y = double.Parse(currentNumber.ToString());
                               currentNumber.Clear();
                           }
                           if (count == 2)
                           {
                               z = double.Parse(currentNumber.ToString());
                               currentNumber.Clear();
                           }
                           count++;
                       }
                       else
                       {
                           currentNumber.Append(line[i].ToString());
                       }   
                   }

                   currentPath.SomePoints.Add(new Point3D(x, y, z));
               }
               return currentPath;
           }
           
       }
   
        
    }
}
