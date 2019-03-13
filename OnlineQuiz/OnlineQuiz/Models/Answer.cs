using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineQuiz.Models
{
    public class Answer : DbContext
    {

        public int AnswerId { get; set; }
        public string A { get; set; }
        public int QuestionId { get; set; }



    }
}
