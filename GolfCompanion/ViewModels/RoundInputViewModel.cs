using CommunityToolkit.Mvvm.ComponentModel;
using GolfCompanion.Models;
using GolfCompanion.Services;
using SharedGolfClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfCompanion.ViewModels
{
    public partial class RoundInputViewModel : ObservableObject
    {
        [ObservableProperty]
        private Tee selectedTee;
        [ObservableProperty]
        private ObservableCollection<IndexedHole> holes;

        [ObservableProperty]
        private IndexedHole selectedIndexedHole;
        public RoundInputViewModel(TeeSelectionService teeSelectionService) 
        {
            SelectedTee = teeSelectionService.SelectedTee;

            Holes = new ObservableCollection<IndexedHole>();
            for (int i = 0; i < selectedTee.Holes.Length; i++)
            {
                Holes.Add(new IndexedHole { Index = i, Hole = selectedTee.Holes[i] });
            }
        }
    }
}
