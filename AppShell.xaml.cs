using MySolarSystem.Data;
using MySolarSystem.Pages;

namespace MySolarSystem;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(SpecificLesson), typeof(SpecificLesson));
	}
}
