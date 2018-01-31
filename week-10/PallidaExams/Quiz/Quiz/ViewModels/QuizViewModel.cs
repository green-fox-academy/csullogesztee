using Quiz.Models;
using System.Collections.Generic;

namespace Quiz.ViewModels
{
    public class QuizViewModel
    {
        public Exercise Question { get; set; }
        public int Score { get; set; }
    }
}
