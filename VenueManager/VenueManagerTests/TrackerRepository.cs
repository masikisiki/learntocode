using System;
using System.Collections.Generic;

namespace VenueManagerTests
{
    internal class TrackerRepository
    {
        private static readonly List<Student> STUDENTS = new List<Student>();
        public TrackerRepository()
        {
        }

        internal bool Exists(Student student)
        {
            return STUDENTS.Contains(student);
        }

        internal void Add(Student student)
        {
            STUDENTS.Add(student);
        }
    }
}