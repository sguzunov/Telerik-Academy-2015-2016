namespace People
{
    public class Person
    {
        public Person()
        {
        }

        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Person CreatePerson(int age)
        {
            var person = new Person();
            person.Age = age;

            if(age % 2 == 0)
            {
                person.Name = "Hogn";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Tina";
                person.Gender = Gender.Female;
            }

            return person;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Age + "-years old " + this.Gender;
        }
    }
}
