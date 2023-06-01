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

        btnEarth.Clicked += async (s, e) => await Shell.Current
        .GoToAsync($"{nameof(SpecificLesson)}?lessonName=earth");

        btnMars.Clicked += async (s, e) => await Shell.Current
        .GoToAsync($"{nameof(SpecificLesson)}?lessonName=mars");

        btnJupiter.Clicked += async (s, e) => await Shell.Current
        .GoToAsync($"{nameof(SpecificLesson)}?lessonName=jupiter");

        btnSaturn.Clicked += async (s, e) => await Shell.Current
        .GoToAsync($"{nameof(SpecificLesson)}?lessonName=saturn");

        btnUranus.Clicked += async (s, e) => await Shell.Current
        .GoToAsync($"{nameof(SpecificLesson)}?lessonName=uranus");

        btnNeptune.Clicked += async (s, e) => await Shell.Current
        .GoToAsync($"{nameof(SpecificLesson)}?lessonName=neptune");
    }
}