using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class Student : User
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SchoolId { get; set; }
        public int CurrentTier { get; set; }
    }
}