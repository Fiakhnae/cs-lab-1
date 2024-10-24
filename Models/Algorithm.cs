using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLab1.Models
{
    public static class Algorithm
    {
        public static void Func1()
        {
            Queue<int> taskQueue = new Queue<int>();
            List<int> processors = new List<int> { 1, 2, 3, 4, 5 };
            HashSet<int> busyProcessors = new HashSet<int>();
            Random random = new Random();

            for (int i = 0; i < 10000; i++) 
            {
                if (random.Next(1, 101) <= 50) 
                {
                    int complexity = random.Next(10, 201); 
                    taskQueue.Enqueue(complexity);
                }
            }

            while (taskQueue.Count > 0)
            {
                int currentTask = taskQueue.Dequeue();
                bool taskAssigned = false;

                foreach (var processor in processors)
                {
                    if (!busyProcessors.Contains(processor))
                    {
                        Debug.WriteLine($"Task with complexity {currentTask} ms assigned to Processor {processor}");
                        busyProcessors.Add(processor);
                        busyProcessors.Remove(processor);
                        taskAssigned = true;
                        break;
                    }
                }

                if (!taskAssigned)
                {
                    taskQueue.Enqueue(currentTask);
                }
            }
        }

        public static void Func2()
        {
            List<int> tasks = new List<int> { 1, 2, 3, 4, 5 };
            int scheduler = 1;
            List<int> processors = new List<int> { 2, 3, 4, 5 };
            Dictionary<int, int> processorTaskTimes = processors.ToDictionary(p => p, p => 0);
            Queue<int> taskQueue = new Queue<int>(tasks);
            Random random = new Random();

            while (taskQueue.Count > 0)
            {
                int currentTask = taskQueue.Dequeue();
                int complexity = random.Next(10, 201); 
                int selectedProcessor = processorTaskTimes.OrderBy(p => p.Value).First().Key;
                processorTaskTimes[selectedProcessor] += complexity;
                Debug.WriteLine($"Task {currentTask} with complexity {complexity} ms assigned to Processor {selectedProcessor} by Scheduler {scheduler}");
            }
        }

        public static void Func3()
        {
            List<int> tasks = new List<int> { 1, 2, 3, 4, 5 };
            int powerfulProcessor = 5;
            List<int> processors = new List<int> { 1, 2, 3, 4, 5 };
            Queue<int> taskQueue = new Queue<int>(tasks);
            int schedulingTime = 4;
            int taskExecutionTime = 20;
            int totalExecutionTime = 0;
            Random random = new Random();

            while (taskQueue.Count > 0)
            {
                int currentTask = taskQueue.Dequeue();
                int complexity = random.Next(10, 201); 
                int selectedProcessor = processors.OrderBy(p => p).First();
                Debug.WriteLine($"Task {currentTask} with complexity {complexity} ms assigned to Processor {selectedProcessor} by Powerful Processor {powerfulProcessor}");
                totalExecutionTime += schedulingTime + complexity;
            }

            Debug.WriteLine($"Powerful Processor {powerfulProcessor} also processes tasks with interruptions for scheduling");
            Debug.WriteLine($"Total execution time: {totalExecutionTime} ms");
        }

    }
}
