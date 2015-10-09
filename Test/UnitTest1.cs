using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EagerLoadTeacherPupils()
        {
            SchoolContext ctx = new SchoolContext();

            List<Teacher> teachers = ctx.Teachers.Include("Pupils").ToList();

            Assert.IsTrue(teachers.Count == 1);
        }

        [TestMethod]
        public void EagerLoadPupilsTeacher()
        {
            SchoolContext ctx = new SchoolContext();

            Pupil pupil = ctx.Pupils.Include("Teacher").Single(x => x.FirstName == "Sam");

            Assert.IsTrue(pupil.Teacher.LastName == "Lanes");
        }
    }
}
