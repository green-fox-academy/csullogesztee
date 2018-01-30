using Quiz.Models;
using Quiz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Services
{
    public class QuizService
    {
        private QuizRepository quizRepository;

        public QuizService(QuizRepository quizRepository)
        {
            this.quizRepository = quizRepository;
        }

        internal void AddNewExercise(Exercise exercise)
        {
            quizRepository.AddExercise(exercise);
        }

        internal Exercise GetQuestion()
        {
            return quizRepository.RandomQuestion();
        }
    }
}
