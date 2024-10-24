using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CSLab1.Models;
using CSLab1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab1.ViewModels {
    public partial class MainViewModel : ObservableObject {
        public MainViewModel() { }
        [ObservableProperty]
        int power1 = 0;
        [ObservableProperty]
        int power2 = 0;
        [ObservableProperty]
        int power3 = 0;
        [ObservableProperty]
        int power4 = 0;
        [ObservableProperty]
        int power5 = 0;
        [ObservableProperty]
        int random = 0;

        [RelayCommand]
        async Task OpenTestPage() {
            Processor p1 = new() { Power = Power1, Random = Random };
            Processor p2 = new() { Power = Power2, Random = Random };
            Processor p3 = new() { Power = Power3, Random = Random };
            Processor p4 = new() { Power = Power4, Random = Random };
            Processor p5 = new() { Power = Power5, Random = Random };
            Singleton.Processors.Clear();
            Singleton.Processors.Add(p1);
            Singleton.Processors.Add(p2);
            Singleton.Processors.Add(p3);
            Singleton.Processors.Add(p4);
            Singleton.Processors.Add(p5);
            await MainThread.InvokeOnMainThreadAsync(async () => {
                await Shell.Current.GoToAsync(nameof(TestPage), true);
            });
        }
    }
}
