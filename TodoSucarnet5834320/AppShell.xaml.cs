using TodoSucarnet5834320.Views;
namespace TodoSucarnet5834320;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));
	}
}
