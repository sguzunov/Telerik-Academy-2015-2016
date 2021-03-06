﻿namespace Exceptions
{
    using System;

    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (/*value < this.MinGrade ||*/ this.MaxGrade < value)
                {
                    throw new ArgumentOutOfRangeException("Grade must be between min and max grade.");
                }

                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Min possible grade cannot be smaller than 0.");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                if (value < this.MinGrade)
                {
                    throw new ArgumentOutOfRangeException("Max possible grade cannot be smaller than min grade.");
                }

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Comments cannot be null.");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentException("Comments cannot be empty.");
                }

                this.comments = value;
            }
        }
    }
}
