using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

        [ObservableProperty]
        private ObservableCollection<Club> clubs;
        [ObservableProperty]
        private Club selectedClub;

        [ObservableProperty]
        private ObservableCollection<ShotType> shotTypes = new ObservableCollection<ShotType>(Enum.GetValues<ShotType>());
        [ObservableProperty]
        private ShotType selectedShotType;

        [ObservableProperty]
        private ObservableCollection<Lie> lies = new ObservableCollection<Lie>(Enum.GetValues<Lie>());
        [ObservableProperty]
        private Lie selectedLie;

        [ObservableProperty]
        private ObservableCollection<Result> results = new ObservableCollection<Result>(Enum.GetValues<Result>());
        [ObservableProperty]
        private Result selectedResult;

        [ObservableProperty]
        private ObservableCollection<Shot> shots;
        public RoundInputViewModel(TeeSelectionService teeSelectionService) 
        {
            SelectedTee = teeSelectionService.SelectedTee;
            Clubs = new ObservableCollection<Club>
            {
                new Club{ ClubId = 1, ClubName="Dr" },
                new Club{ ClubId = 2, ClubName="3W" },
                new Club{ ClubId = 3, ClubName="4H" },
                new Club{ ClubId = 4, ClubName="5i" },
                new Club{ ClubId = 5, ClubName="6i" },
                new Club{ ClubId = 6, ClubName="7i" },
                new Club{ ClubId = 7, ClubName="8i" },
                new Club{ ClubId = 8, ClubName="9i" },
                new Club{ ClubId = 9, ClubName="Pw" },
                new Club{ ClubId = 10, ClubName="Gw" },
                new Club{ ClubId = 11, ClubName="Aw" },
                new Club{ ClubId = 12, ClubName="Sw" },
                new Club{ ClubId = 13, ClubName="Lw" },
                new Club{ ClubId = 14, ClubName="Pu" }
            };

            Holes = new ObservableCollection<IndexedHole>();
            for (int i = 0; i < selectedTee.Holes.Length; i++)
            {
                Holes.Add(new IndexedHole { Index = i, Hole = selectedTee.Holes[i] });
            }
        }
        [RelayCommand]
        async Task AddShot()
        {

        }

        [RelayCommand]
        async Task AddHole()
        {

        }
    }
}
