namespace SchoolClasses.Models
{
    using System;
    using System.Collections.Generic;
    using SchoolClasses.Interfaces;

    public class Class : IClasses,IComment
    {
        private string textID;
        List<Teacher> setOfTeachers;

        public Class(string textIdentifier, Teacher[] setTeachers)
        {
            this.TextID = textIdentifier;
            this.setOfTeachers = new List<Teacher>();
            setOfTeachers.AddRange(setOfTeachers);
        }
        
        public string TextID
        {
            get 
            {
                return this.textID;
            }
            set
            {
                this.textID = value;
            }
        }

        public List<string> Comment { get; set; }        
              
        public void AddComment(string comm)
        {
            this.Comment.Add(comm);   
        }
    }
}
