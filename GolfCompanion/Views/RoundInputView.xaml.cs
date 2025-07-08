using CommunityToolkit.Mvvm.ComponentModel;
using GolfCompanion.Models;
using GolfCompanion.Services;
using GolfCompanion.ViewModels;
using SharedGolfClasses;

namespace GolfCompanion.Views;

public partial class RoundInputView : ContentPage
{
	public RoundInputView(RoundInputViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}