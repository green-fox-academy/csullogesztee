using Quiz.Entities;
using Quiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Repositories
{
    public class QuizRepository
    {
        private QuizContext quizContext;

        public QuizRepository(QuizContext quizContext)
        {
            this.quizContext = quizContext;
        }

        public List<Exercise> AllExercise()
        {
            return quizContext.Exercises.ToList();
        }

        public void AddExercise(Exercise exercise)
        {
            quizContext.Exercises.Add(exercise);
            quizContext.SaveChanges();
        }

        public Exercise RandomQuestion()
        {
            Random random = new Random();
            return AllExercise()[Convert.ToInt16(random.Next(AllExercise().Count()))];
        }
    }
}
