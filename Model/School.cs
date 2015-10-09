using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class School
    {
        public School()
        {
            Teacher = new List<Teacher>();
        }

        public int Id { get; set; }

        public ICollection<Teacher> Teacher { get; set; }
    }
}
