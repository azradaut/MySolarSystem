using Microsoft.Maui.Controls;
using MySolarSystem.Data;

namespace MySolarSystem.Pages
{
    public partial class QuestionPage : ContentPage
    {
        private QuizManager quizManager;
        private List<Question> questions;
        private int currentQuestionIndex;

        public QuestionPage()
        {
            InitializeComponent();

            quizManager = new QuizManager();
            questions = quizManager.GetRandomQuestions(5);
            currentQuestionIndex = 0;

            AnswerChoicesListView.ItemSelected += AnswerChoicesListView_ItemSelected;

            DisplayQuestion(questions[currentQuestionIndex]);
        }

        private void DisplayQuestion(Question question)
        {
            QuestionImage.Source = question.ImageUrl;
            QuestionTextLabel.Text = question.Text;
            AnswerChoicesListView.ItemsSource = question.Choices;
            AnswerChoicesListView.SelectedItem = null; // Clear the selected item

            // Set accessibility properties
            QuestionImage.SetValue(SemanticProperties.DescriptionProperty, $"Image related to the question: {question.Text}");
            QuestionTextLabel.SetValue(SemanticProperties.HeadingLevelProperty, SemanticHeadingLevel.Level1);
            AnswerChoicesListView.SetValue(SemanticProperties.HintProperty, "Choose an answer option");
        }

        private async void NextButton_Clicked(object sender, EventArgs e)
        {
            // Handle the user's answer and move to the next question

            if (AnswerChoicesListView.SelectedItem != null)
            {
                var selectedAnswer = AnswerChoicesListView.SelectedItem.ToString();
                var currentQuestion = questions[currentQuestionIndex];
                bool isCorrect = selectedAnswer == currentQuestion.Choices[currentQuestion.CorrectAnswerIndex];

                if (currentQuestionIndex == questions.Count - 1)
                {
                    
                    string alertMessage = isCorrect ? "Correct!" : $"Incorrect! The correct answer was: {currentQuestion.Choices[currentQuestion.CorrectAnswerIndex]}";
                    await DisplayAlert("Answer", alertMessage, "OK");
                    currentQuestion.SelectedChoice = selectedAnswer;
                }
                else
                {
                    string alertMessage = isCorrect ? "Correct!" : $"Incorrect! \nThe correct answer was: \r\n\r\n{currentQuestion.Choices[currentQuestion.CorrectAnswerIndex]}";
                    await DisplayAlert("Answer", alertMessage, "OK");

                    currentQuestion.SelectedChoice = selectedAnswer;
                }

                if (currentQuestionIndex < questions.Count - 1)
                {
                    currentQuestionIndex++;
                    DisplayQuestion(questions[currentQuestionIndex]);
                }
                else
                {
                    // All questions answered --> calculate score and show score page
                    int score = CalculateScore();

                    string message;
                    if (score == questions.Count)
                    {
                        message = "Amazing! You got all the answers correct!";
                    }
                    else if (score >= questions.Count / 2)
                    {
                        message = "Great job! You're doing well!";
                    }
                    else
                    {
                        message = "Keep practicing! You can do better!";
                    }
                    await DisplayAlert("Quiz Score", $"Your score: {score} out of {questions.Count}\n\n{message}", "OK");

                    // Go back to the Quiz page
                    await Navigation.PopToRootAsync();
                }

            }
            else
            {
                await DisplayAlert("Warning", "Please select an answer", "OK");
            }
        }


        private int CalculateScore()
        {
            int score = 0;

            foreach (var question in questions)
            {
                if (question.SelectedChoice != null)
                {
                    var selectedAnswer = question.SelectedChoice;
                    var correctAnswer = question.Choices[question.CorrectAnswerIndex];

                    if (selectedAnswer == correctAnswer)
                    {
                        score++;
                    }
                }
            }

            return score;
        }

        private void AnswerChoicesListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // Handle the selected answer choice

            // Set accessibility properties for the selected answer choice
            var selectedAnswerChoice = e.SelectedItem as string;
            if (selectedAnswerChoice != null)
            {
                AnswerChoicesListView.SetValue(SemanticProperties.DescriptionProperty, $"Selected answer: {selectedAnswerChoice}");
            }

        }
    }
}
