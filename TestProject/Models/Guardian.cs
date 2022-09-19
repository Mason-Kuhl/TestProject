using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class Guardian
    {
        public int Id { get; set; }
        public List<int> StudentId { get; set; }
    }
}