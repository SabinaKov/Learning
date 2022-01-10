using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    public class UIAccess
    {
        public int SimplyDefinedProp { get; set; }


        private string? _reakceVypoctu;

        public string? ReakceVypoctu
        {
            get { return _reakceVypoctu; }
            set
            {
                _reakceVypoctu = value;
                Console.WriteLine(_reakceVypoctu);
            }
        }


        public async Task Run()
        {

            try // Tento try-catch block slouží pro SYNCHRONNÍ metody
            {
                //OtherLearningStuff.ClassCastingAndOverriding();
                //OtherLearningStuff.AsyncAwait();
                //OtherLearningStuff.EnumsExplanation();
                Analysis analysis = new Analysis();
                //analysis.ShowExample();
                await analysis.ShowExampleAsync(sender => ReakceVypoctu = sender); // Lambda


            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba:");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
