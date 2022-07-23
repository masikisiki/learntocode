using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VenueManagerTests
{
    public class VenueTrackerServiceTests
    {
        [Fact]
        public void AddStudent_GivenValidStudent_ShouldBeAddedToTheTracker()
        {
            //Arrange
            var trackerRepository = new TrackerRepository();
            var student = new Student(201001, "John", CourseCode.CSC100, 2);
            var trackerService = new VenueTrackerService(trackerRepository);
            //Act
            trackerService.StudentIn(student);
            //Assert
            Assert.True(trackerRepository.Exists(student));
        }
    }

    internal class Student
    {
        private int v1;
        private string v2;
        private CourseCode cSC100;
        private int v3;

        public Student(int v1, string v2, CourseCode cSC100, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.cSC100 = cSC100;
            this.v3 = v3;
        }
    }

    internal enum CourseCode
    {
        CSC100
    }
}
