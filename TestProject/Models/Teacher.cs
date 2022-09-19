using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class Teacher : User
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int SchoolId { get; set; }
    }
}