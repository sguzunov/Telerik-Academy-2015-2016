namespace PersonClass
{
    using System;

    public class Person
    {
        private string name;
        private short? age;

        public Person(string name, short? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name)
            : this(name, null)
        { 
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (IsValdName(value) == false)
                {
                    throw new ArgumentException("Incorrect input data for name");
                }

                this.name = value;
            }
        }

        private short? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 200)
                {
                    throw new ArgumentOutOfRangeException("Incorrect input data.Age CANNOT be(age < 0) or ( age > 200)");
                }

                this.age = value;
            }
        }

        private bool IsValdName(string value)
        {
            if (value[0] < 'A' || value[0] > 'Z')
            {
                return false;
            }
            if (value == null)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return string.Format("Name: " + this.Name + "\n" + "Age " + this.Age);
        }
    }
}
