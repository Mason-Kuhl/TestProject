using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class Admin : User
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
    }
}