namespace Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private string firstName;
        private string lastName;
        private IList<Exam> exams;

        public Student(string firstName, string lastName, IList<Exam> exams)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("First name cannot be null.");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("First name cannot be empty string.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Last name cannot be null.");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Last name cannot be empty string.");
                }

                this.lastName = value;
            }
        }

        public IList<Exam> Exams
        {
            get
            {
                return this.exams;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Exams cannot be null.");
                }

                if (value.Count == 0)
                {
                    throw new ArgumentException("Exam list cannot be empty.");
                }

                this.exams = value;
            }
        }

        public IList<ExamResult> CheckExams()
        {
            IList<ExamResult> results = new List<ExamResult>();

            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }

        public double CalcAverageExamResultInPercents()
        {
            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams();

            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}
