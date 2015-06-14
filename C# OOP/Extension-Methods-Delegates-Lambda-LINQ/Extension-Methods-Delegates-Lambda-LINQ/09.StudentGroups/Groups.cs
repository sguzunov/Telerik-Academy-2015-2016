namespace StudentGroups
{
    using System;

    public class Groups
    {
        private ushort groupNumber;
        private string departmentName;

        public Groups(ushort grpNumber, string dprtName)
        {
            this.GroupNumber = grpNumber;
            this.DepartmentName = dprtName;
        }

        public ushort GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect nput data!");
                }
                this.groupNumber = value;
            }
        }

        public string DepartmentName
        {
            get
            {
                return this.departmentName;
            }
            set
            {
                if (ValidateDepartmentName(value) == false)
                {
                    throw new ArgumentException("Incorrect input data!");
                }

                this.departmentName = value; 
            }
        }

        private bool ValidateDepartmentName(string name)
        {
            foreach (var ch in name)
            {
                if (char.IsDigit(ch))
                {
                    return false;
                    break;
                }
            }
            return true;
        }
   

    }
}
