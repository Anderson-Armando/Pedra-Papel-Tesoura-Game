using Android.Media.Metrics;
using CommunityToolkit.Mvvm.ComponentModel;
using PedraPapelTesouraGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapelTesouraGame.ViewModels
{
    public partial class GameViewModels : ObservableObject 
    {
        [ObservableProperty]
        private string _nome;

        [ObservableProperty]
        private int _score;

        [ObservableProperty]
        private string _playerImage;

        [ObservableProperty]
        private string _enemyImage;

        [ObservableProperty]
        private string _result;

        [ObservableProperty]
        private string _playerChoice;

        
    }
}
