using System;
using System.Collections.Generic;
using System.Linq;

namespace MySolarSystem.Data
{
    public class QuizManager
    {
        private List<Question> allQuestions;
        private Random rng;

        public QuizManager()
        {
            allQuestions = new List<Question>
            {
                new Question
                {
                    Text = "Question 1",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    CorrectAnswerIndex = 1,
                    ImageUrl = "mercury.svg"
                },

                new Question
                {
                    Text = "Question 2",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    CorrectAnswerIndex = 0,
                    ImageUrl = "venus.svg"
                },

                new Question
                {
                    Text = "Question 3",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    CorrectAnswerIndex = 2,
                    ImageUrl = "earth.svg"
                },

                new Question
                {
                    Text = "Question 4",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    CorrectAnswerIndex = 2,
                    ImageUrl = "mars.svg"
                },


                new Question
                {
                    Text = "Question 5",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    CorrectAnswerIndex = 3,
                    ImageUrl = "jupiter.svg"
                },

                new Question
                {
                    Text = "Question 6",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    CorrectAnswerIndex = 1,
                    ImageUrl = "saturn.svg"
                },

                new Question
                {
                    Text = "Question 7",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    CorrectAnswerIndex = 0,
                    ImageUrl = "uranus.svg"
                },

                new Question
                {
                    Text = "Question 8",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    CorrectAnswerIndex = 1,
                    ImageUrl = "neptune.svg"
                },

                new Question
                {
                    Text = "Question 9",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    CorrectAnswerIndex = 2,
                    ImageUrl = "pluto.svg"
                },

                new Question
                {
                    Text = "Question 10",
                    Choices = new List<string> { "Choice 1", "Choice 2", "Choice 3", "Choice 4" },
                    CorrectAnswerIndex = 3,
                    ImageUrl = "sun.svg"
                }
                // Add the remaining 9 questions here
                // ...
            };

            rng = new Random();
        }

        public List<Question> GetRandomQuestions(int count)
        {
            List<Question> selectedQuestions = allQuestions.OrderBy(_ => rng.Next()).Take(count).ToList();
            return selectedQuestions;
        }
    }
}
