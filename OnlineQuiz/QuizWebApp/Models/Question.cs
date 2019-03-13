using System.Collections.Generic;

namespace QuizWebApp.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Description { get; set; }
        private int _CorrectAnswerId { get; set; }
        public List<Answer> Answers { get; set; }

        public bool Validate(Answer A)
        {
            return (A.AnswerId == _CorrectAnswerId) ;
        }
    }
}