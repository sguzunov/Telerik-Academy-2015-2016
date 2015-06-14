namespace SchoolClasses.Models
{
    using System;
    using SchoolClasses.Interfaces;
    using System.Collections.Generic;

    public class Disciplines: IDiscipline,IComment
    {
        private string name;
        private ushort numberOfLectures;
        private ushort numberOfExercises;
        
        public Disciplines(string name,ushort numLectures,ushort numExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numLectures;
            this.NumberOfExercises = numExercises;
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                if (IsValidName(value) == false)
                {
                    throw new ArgumentException("Inccorect input data for name!");
                }
                this.name = value;
            }
        }

        public ushort NumberOfLectures
        {
            get 
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }

        public ushort NumberOfExercises
        {
            get 
            {
                return numberOfExercises;
            }
            set
            {
                this.numberOfExercises = value;
            }
        }

        public List<string> Comment { get; set; }
        

        public void AddComment(string comment)
        {
            this.Comment.Add(comment);
        }

        private bool IsValidName(string name)
        {
            if (name[0] < 'A' || name[0] > 'Z')
            {
                return false;
            }

            foreach (var ch in name)
            {
                if (char.IsDigit(ch))
                {
                    return false;
                }
            }

            if (name == null)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return string.Format(this.Name);
        }

    }
}
