using Quiz.Models;
using Quiz.Repositories;
using Quiz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Services
{
    public class QuizService
    {
        private QuizRepository quizRepository;
        private static List<Exercise> listOfAllExercise;

        public QuizService(QuizRepository quizRepository)
        {
            this.quizRepository = quizRepository;
            listOfAllExercise = quizRepository.AllExercise();
        }

        internal void AddNewExercise(Exercise exercise)
        {
            quizRepository.AddExercise(exercise);
        }

        internal Exercise GetQuestion()
        {
            Random random = new Random();
            var currentQuestion = listOfAllExercise[Convert.ToInt16(random.Next(listOfAllExercise.Count()))];
            listOfAllExercise.Remove(currentQuestion);
            return currentQuestion;
        }

        public bool CorrectAnswer(int questionId, int choosenAnswer)
        {
            var currentQuestin = quizRepository.SearchQuestion(questionId);

            return currentQuestin.Correct == choosenAnswer;
        }

        public bool IsThereAnyQuestion()
        {
            return listOfAllExercise.Count() > 0;
        }

        public QuizViewModel GenerateView(int? score = 0)
        {
            QuizViewModel actualView = new QuizViewModel()
            {
                Question = GetQuestion(),
                Score = (int)score
            };
            return actualView;
        }
    }
}
