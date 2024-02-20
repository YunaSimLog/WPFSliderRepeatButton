using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WPFSliderRepeatButton
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _value;

        public MainViewModel()
        {
            Value = 50;
        }

        [RelayCommand]
        private void Increase()
        {
            Value++;
        }

        [RelayCommand]
        private void Decrease()
        {
            Value--;
        }
    }
}
