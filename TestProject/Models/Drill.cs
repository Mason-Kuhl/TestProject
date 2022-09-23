using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class Drill
    {
        public String title { get; set; }
        public String section { get; set; }
        public List<Question> questions { get; set; }
        public List<Question> questionsCorrect { get; set; }
        public List<Question> questionsWrong { get; set; }
    }
}