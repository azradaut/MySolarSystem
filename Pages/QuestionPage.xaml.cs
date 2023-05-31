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

            // Optionally, you can update other UI elements based on the question
        }

        private async void NextButton_Clicked(object sender, EventArgs e)
        {
            // Handle the user's answer and move to the next question

            if (AnswerChoicesListView.SelectedItem != null)
            {
                var selectedAnswer = AnswerChoicesListView.SelectedItem.ToString();
                var currentQuestion = questions[currentQuestionIndex];

                // Check if the selected answer is correct
                bool isCorrect = selectedAnswer == currentQuestion.Choices[currentQuestion.CorrectAnswerIndex];

                if (currentQuestionIndex == questions.Count - 1)
                {
                    // Show a pop-up for the last question review
                    string alertMessage = isCorrect ? "Correct!" : $"Incorrect! The correct answer was: {currentQuestion.Choices[currentQuestion.CorrectAnswerIndex]}";
                    await DisplayAlert("Answer", alertMessage, "OK");

                    // Update the selected choice for the last question
                    currentQuestion.SelectedChoice = selectedAnswer;
                }
                else
                {
                    // Show a pop-up indicating if the answer is correct or not
                    string alertMessage = isCorrect ? "Correct!" : $"Incorrect! \nThe correct answer was: \r\n\r\n{currentQuestion.Choices[currentQuestion.CorrectAnswerIndex]}";
                    await DisplayAlert("Answer", alertMessage, "OK");

                    // Update the selected choice for the current question
                    currentQuestion.SelectedChoice = selectedAnswer;
                }

                if (currentQuestionIndex < questions.Count - 1)
                {
                    currentQuestionIndex++;
                    DisplayQuestion(questions[currentQuestionIndex]);
                }
                else
                {
                    // All questions answered, calculate score and show score page
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

                    // Show the quiz score and feedback
                    await DisplayAlert("Quiz Score", $"Your score: {score} out of {questions.Count}\n\n{message}", "OK");

                    // Go back to the Home page
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
                        // Increase the score for each correct answer
                        score++;
                    }
                }
            }

            return score;
        }

        private void AnswerChoicesListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // Handle the selected answer choice
            // You can access the selected item using e.SelectedItem
        }
    }
}
