namespace GroupedByGroupNumber
{
    using System;

    public class Students
    {
        private string name;
        private string groupName;

        public Students(string studentName, string group)
        {
            this.name = studentName;
            this.groupName = group;
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
                    throw new ArgumentException("Incorrect input data!");
                }

                this.name = value;
            }
        }

        public string GroupName
        {
            get
            {
                return this.groupName;
            }
            set
            {
                if (IsValidName(value)==false)
                {
                    throw new ArgumentException("Incorrect input data!");
                }

                this.groupName = value;
            }
        }
        
        private bool IsValidName(string chechName)
        {
            foreach (var ch in chechName)
            {
                if (char.IsDigit(ch))
                {
                    return false;
                    break;
                }                
            }
            return true;
        }

        public override string ToString()
        {
            return string.Format(this.Name + " " + this.GroupName);
        }

    }
}
