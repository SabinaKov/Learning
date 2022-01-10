using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    public class Analysis
    {
        private Dictionary<Enums.AnalysisType, Func<int>> _analyses;
        public Analysis()
        {
            _analyses = new Dictionary<Enums.AnalysisType, Func<int>>()
            {
                { Enums.AnalysisType.MinimalLoad, MinimalLoadAnalysis },
                { Enums.AnalysisType.Durability, DurabilityAnalysis },
                { Enums.AnalysisType.SafetyFactor, SafetyFactorAnalysis }
            };
        }
        private bool Func1()
        {
            return true;
        }

        private bool Func2(double input1)
        {
            return true;
        }
        private bool Func3(double input1, int input2)
        {
            return true;
        }

        public int SafetyFactorAnalysis()
        {
            // computations...
            return 0;
        }
        public int MinimalLoadAnalysis()
        {
            throw new NotImplementedException();
        }
        public int DurabilityAnalysis()
        {
            throw new ArgumentNullException("My own exception");
        }

        public void ShowExample()
        {
            Func<bool> func = Func1;
            bool result = func();

            Func<double, bool> func2 = Func2;
            bool result2 = func2(20.0);

            Func<double, int, bool> func3 = Func3;
            bool result3 = func3(10.0, 2);

            foreach (var item in _analyses)
            {
                item.Value();
            }

        }

        public async Task ShowExampleAsync(Action<string> reakceVypoctu)
        {
            List<Task> tasks = new List<Task>();
            foreach (var item in _analyses)
            {
                tasks.Add(Task.Run(() => item.Value()));
            }

            Task allTasks = Task.WhenAll(tasks);
            try
            {
                await allTasks;
            }
            catch (Exception)
            {
                if (allTasks.Exception != null)
                {
                    foreach (var item in allTasks.Exception.InnerExceptions)
                    {
                        reakceVypoctu(item.Message);
                    }
                }

            }
            
        }



    }
}
