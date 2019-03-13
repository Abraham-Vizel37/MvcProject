using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizWebApp.Models
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public List<Question> Questions { get; set; }
    }
}
