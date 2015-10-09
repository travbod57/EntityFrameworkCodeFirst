using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Teacher
    {
        public Teacher()
        {
            Pupils = new List<Pupil>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public int SchoolId { get; set; }
        public School School { get; set; }

        public ICollection<Pupil> Pupils { get; set; }
    }
}
