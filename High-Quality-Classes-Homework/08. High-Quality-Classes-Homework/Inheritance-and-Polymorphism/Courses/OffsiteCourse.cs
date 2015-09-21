namespace InheritanceAndPolymorphism.Courses
{
    using System;
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;



        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get { return this.town; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Town name can not be empty.");
                }
                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
