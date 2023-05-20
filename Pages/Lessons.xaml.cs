namespace MySolarSystem.Pages;

public partial class Lessons : ContentPage
{
	public Lessons()
	{
		InitializeComponent();

		btnSolarSystem.Clicked += async (s, e) => await Shell.Current
		.GoToAsync($"{nameof(SpecificLesson)}?lessonName=solar_system");

        btnMercury.Clicked += async (s, e) => await Shell.Current
        .GoToAsync($"{nameof(SpecificLesson)}?lessonName=mercury");

        btnVenus.Clicked += async (s, e) => await Shell.Current
        .GoToAsync($"{nameof(SpecificLesson)}?lessonName=venus");

        btnMars.Clicked += async (s, e) => await Shell.Current
        .GoToAsync($"{nameof(SpecificLesson)}?lessonName=mars");
    }
}