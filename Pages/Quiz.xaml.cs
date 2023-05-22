namespace MySolarSystem.Pages;

public partial class Quiz : ContentPage
{
	public Quiz()
	{
		InitializeComponent();

        btnStartQuiz.Clicked += async (s, e) => await Shell.Current
        .GoToAsync($"{nameof(QuestionPage)}?questionNo=question1");
    }
}