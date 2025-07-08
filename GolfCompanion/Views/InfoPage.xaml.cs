using GolfCompanion.Services;
using GolfCompanion.ViewModels;

namespace GolfCompanion.Views;

public partial class InfoPage : ContentPage
{
	public InfoPage(CourseViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}