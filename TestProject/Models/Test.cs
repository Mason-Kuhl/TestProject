using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class Test:Drill
    {
        public DateTime dueDate { get; set; }
        public double grade { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int totalMinutes { get; set; }
    }
}