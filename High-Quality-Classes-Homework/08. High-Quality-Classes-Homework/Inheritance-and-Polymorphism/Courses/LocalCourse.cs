

namespace InheritanceAndPolymorphism.Courses
{
    using System;
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;
        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }
        public string Lab
        {
            get { return this.lab; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Lab name can not be emptey.");
                }
                this.lab = value;
            }
        }



        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
