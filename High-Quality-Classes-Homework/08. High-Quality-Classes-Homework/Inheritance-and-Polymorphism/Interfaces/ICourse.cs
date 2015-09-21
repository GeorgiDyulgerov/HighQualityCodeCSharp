namespace InheritanceAndPolymorphism.Interfaces
{
    using System.Collections.Generic;
    interface ICourse
    {
        string CourseName { get; }
        string TeacherName { get; }
        IList<string> Students { get; }
    }
}
