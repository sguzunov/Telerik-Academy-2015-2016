namespace SchoolClasses.Models
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private List<Class> classes;

        public School(Class[] rangeOfClasses)
        {
            this.Classes = new List<Class>();
            this.Classes.AddRange(rangeOfClasses);
        }

        public List<Class> Classes
        {
            get { return this.classes; }
            private set { this.classes = value; }
        }

        public void AddClass(Class newClass)
        {
            this.Classes.Add(newClass);
        }

        public void RemoveClass(Class oldClass)
        {
            this.Classes.Remove(oldClass);
        }

    }
}
