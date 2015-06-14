namespace SchoolClasses.Models
{
    using System.Collections.Generic;
    using SchoolClasses.Interfaces;

    public class Teacher : Person
    {
        List<Disciplines> setOfDisciplines;

        public Teacher(string firstName, string lastName, Disciplines[] setDisciplines)
            : base(firstName, lastName)
        {
            this.setOfDisciplines = new List<Disciplines>();
            this.setOfDisciplines.AddRange(setDisciplines);
        }
    }
}
