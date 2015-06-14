namespace AnimalHierarchy.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AnimalHierarchy.Interfaces;

    public abstract class Animal : ISound,IBreed
    {
        private string name;
        private byte age;
        private string sex;

        public Animal(string animalName, byte animalAge, string animalSex)
        {
            this.Name = animalName;
            this.Age = animalAge;
            this.Sex = animalSex; 
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

        public byte Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect input data!");
                }

                this.age = value;
            }
        }

        public virtual string Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                if (value != "male" && value != "female" && value != "Male" && value != "Female")
                {
                    throw new ArgumentException("Incorrect input data!");
                }

                this.sex = value;
            }
        }

        public abstract string Breed { get; set; }

        public abstract void Sound();        

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
                    break;
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
            return string.Format(this.Name + " " + this.Age + " " + this.Sex);
        }

        public static double AverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(x => x.Age);
        }
    }
}
