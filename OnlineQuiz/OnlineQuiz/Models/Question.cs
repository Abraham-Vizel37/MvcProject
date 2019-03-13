using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineQuiz.Models
{
    public class Question : DbContext
    {
        public int QuestionId { get; set; }

        public string Q { get; set; }

        public int AnswerId { get; set; }




    }
}
