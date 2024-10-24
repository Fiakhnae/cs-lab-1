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
            new Thread(async () => {
                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                Task task1 = Task.Delay(10000);
                Task task2 = Task.Run(() => {
                    Random random = new Random();
                    int step;
                    while (true) {
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
                    await Shell.Current.DisplayAlert("Результат",
                        $"Процесор №1\nTask1: {count1}\nTask2: {count2}\nTask3: {count3}\n", "OK");
                });

            }) { IsBackground = true }.Start();
            await Task.Delay(1000);
            new Thread(async () => {
                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                Task task1 = Task.Delay(10000);
                Task task2 = Task.Run(() => {
                    Random random = new Random();
                    int step;
                    while (true) {
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
                    await Shell.Current.DisplayAlert("Результат",
                        $"Процесор №2\nTask1: {count1}\nTask2: {count2}\nTask3: {count3}\n", "OK");
                });

            }) { IsBackground = true }.Start();
            await Task.Delay(1000);
            new Thread(async () => {
                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                Task task1 = Task.Delay(10000);
                Task task2 = Task.Run(() => {
                    Random random = new Random();
                    int step;
                    while (true) {
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
                    await Shell.Current.DisplayAlert("Результат",
                        $"Процесор №3\nTask1: {count1}\nTask2: {count2}\nTask3: {count3}\n", "OK");
                });

            }) { IsBackground = true }.Start();
            await Task.Delay(1000);
            new Thread(async () => {
                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                Task task1 = Task.Delay(10000);
                Task task2 = Task.Run(() => {
                    Random random = new Random();
                    int step;
                    while (true) {
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
                    await Shell.Current.DisplayAlert("Результат",
                        $"Процесор №4\nTask1: {count1}\nTask2: {count2}\nTask3: {count3}\n", "OK");
                });

            }) { IsBackground = true }.Start();
            await Task.Delay(1000);
            new Thread(async () => {
                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                Task task1 = Task.Delay(10000);
                Task task2 = Task.Run(() => {
                    Random random = new Random();
                    int step;
                    while (true) {
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
                    await Shell.Current.DisplayAlert("Результат",
                        $"Процесор №5\nTask1: {count1}\nTask2: {count2}\nTask3: {count3}\n", "OK");
                });

            }) { IsBackground = true }.Start();
        }
    }
}
