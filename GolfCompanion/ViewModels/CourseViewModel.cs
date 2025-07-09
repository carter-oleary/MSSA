using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GolfCompanion.Models;
using GolfCompanion.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SharedGolfClasses;
using GolfCompanion.Views;

namespace GolfCompanion.ViewModels
{
    public partial class CourseViewModel : ObservableObject
    {
        [ObservableProperty]
        private GolfCourse golfCourse;

        [ObservableProperty]
        private ObservableCollection<Tee> filteredTees;

        [ObservableProperty]
        private Tee selectedTee;

        [ObservableProperty]
        private ObservableCollection<string> genderOptions;

        [ObservableProperty]
        private string selectedGender;

        public event EventHandler<string>? CourseLoaded;
        public event EventHandler<string>? CourseLoadFailed;

        private readonly CourseInfoService _courseService;
        private readonly TeeSelectionService _teeSelectionService;

        partial void OnSelectedGenderChanged(string value)
        {
            UpdateFilteredTees();
        }

        public CourseViewModel(CourseInfoService courseService, TeeSelectionService teeSelectionService)
        {
            _courseService = courseService;
            _teeSelectionService = teeSelectionService;
            GenderOptions = new ObservableCollection<string> { "Male", "Female" };
            FilteredTees = new ObservableCollection<Tee>();
            SelectedGender = "Male";
        }

        [RelayCommand]
        private async Task GetCourse()
        {
            try
            {
                var result = await _courseService.GetCourseInfoAsync(20103);
                GolfCourse = result;
                UpdateFilteredTees();
                
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
            }

        }

        private void UpdateFilteredTees()
        {
            FilteredTees.Clear();
            // Check for existing course
            if (GolfCourse?.Tees == null) return;

            var courseTees = SelectedGender == "Male" ? GolfCourse.Tees.Male : GolfCourse.Tees.Female;
            if (courseTees != null)
            {
                foreach (var tee in courseTees)
                {
                    FilteredTees.Add(tee);
                }
            }
        }

        [RelayCommand]
        private async Task GoToRoundInput()
        {
            if(SelectedTee == null)
            {
                await Shell.Current.DisplayAlert("Select Tee", "Please select a tee to input your round", "OK");
                return;
            }

            _teeSelectionService.SelectedTee = SelectedTee;
            _teeSelectionService.Course = GolfCourse;
            await Shell.Current.GoToAsync(nameof(RoundInputView));

        }

        
    }

}
