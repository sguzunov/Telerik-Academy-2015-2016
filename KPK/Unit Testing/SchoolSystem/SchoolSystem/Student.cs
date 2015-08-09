namespace SchoolSystem
{
    using System;

    public class Student
    {
        private const int MIN_ID_VALUE = 10000;
        private const int MAX_ID_VALUE = 99999;

        private string name;
        private int id;

        public Student(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.ValidateName(value);

                this.name = value;
            }
        }

        public int ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value < MIN_ID_VALUE || value > MAX_ID_VALUE)
                {
                    throw new ArgumentOutOfRangeException(string.Format("ID must be in range of ({0},{1})",
                        MIN_ID_VALUE, MAX_ID_VALUE));
                }

                this.id = value;
            }
        }
    }
}
