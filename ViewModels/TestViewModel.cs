using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CSLab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab1.ViewModels {
    public partial class TestViewModel : ObservableObject {
        public TestViewModel() {

        }
        [RelayCommand]
        async Task BeginWork() {

            await Work();
            await Task.Delay(15000);
            await Shell.Current.DisplayAlert("Успішно", "Успішно тести пройдені", "ОК");
        }
        async Task Work() {
            CreateThread("1");
            await Task.Delay(1000);
            CreateThread("2");
            await Task.Delay(1000);
            CreateThread("3");
            await Task.Delay(1000);
            CreateThread("4");
            await Task.Delay(1000);
            CreateThread("5");
        }
        void CreateThread(string id) {
            new Thread(async () => {
                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                int operations = 0;
                Task task1 = Task.Delay(10000);
                Task task2 = Task.Run(() => {
                    Random random = new Random();
                    int step;
                    while (true) {
                        operations += 3;
                        step = random.Next(0, 101);
                        if (step >= Singleton.Processors[0].Random) {
                            continue;
                        }
                        Algorithm.Func1();
                        count1++;
                        step = random.Next(0, 101);
                        if (step >= Singleton.Processors[0].Random) {
                            continue;
                        }
                        Algorithm.Func2();
                        count2++;
                        step = random.Next(0, 101);
                        if (step >= Singleton.Processors[0].Random) {
                            continue;
                        }
                        Algorithm.Func3();
                        count3++;
                        step = random.Next(0, 101);
                        if (step >= Singleton.Processors[0].Random) {
                            continue;
                        }
                    }
                });
                await Task.WhenAny(task1, task2);
                await MainThread.InvokeOnMainThreadAsync(async () => {
                    int count = count1 + count2 + count3;
                    await Shell.Current.DisplayAlert("Результат",
                        $"Процесор №{id}\nTask: {count1}\nTask2: {count2}\nTask3: {count3}" +
                        $"\nFinished Operations: {count}/{operations}" +
                        $"\nEfficiency: {Math.Round((double)count / operations * 100, 5)}%", "OK");
                });

            }) { IsBackground = true }.Start();
        }
    }
}
