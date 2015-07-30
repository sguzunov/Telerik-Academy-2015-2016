namespace Exceptions
{
    using System;

    public class CSharpExam : Exam
    {
        private const int MIN_SCORE_VALUE = 0;
        private const int MAX_SCORE_VALUE = 100;

        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < MIN_SCORE_VALUE || MAX_SCORE_VALUE < value)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Score must be in range ({0},{1}", MIN_SCORE_VALUE, MAX_SCORE_VALUE));
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, MIN_SCORE_VALUE, MAX_SCORE_VALUE, "Exam result calculated by score.");
        }
    }
}
