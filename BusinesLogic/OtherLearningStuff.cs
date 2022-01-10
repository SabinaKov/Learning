using BusinesLogic.Models.Animals;

namespace BusinesLogic
{
    public class OtherLearningStuff
    {
        void CastingAndTypeConversion()
        {
            // Casting:
            int? nullableInt = 3;
            int clasicInt = (int)nullableInt;

            // Casting:
            double desetinneCislo = 10.02;
            int orezaneCislo = (int)desetinneCislo;

            // Type conversion:
            string cisloString = "10.2";
            double cisloDouble = Convert.ToDouble(cisloString);
        }
        #region enums
        public static void EnumsExplanation()
        {
            IntExample();
            StringExample();
            EnumExample();
        }

        private static void EnumExample()
        {

            Enums.AnalysisType analysisType = Enums.AnalysisType.SafetyFactor;

            switch (analysisType)
            {
                case Enums.AnalysisType.MinimalLoad:
                    break;
                case Enums.AnalysisType.Durability:
                    break;
                case Enums.AnalysisType.SafetyFactor:
                    break;
                default:
                    break;
            }
        }

        private static void StringExample()
        {

            string analysisTypeStr = "Safety factor";

            if (analysisTypeStr == "Safety factor")
            {
                // .. calc for analysis type Safety factor
            }
            else if (analysisTypeStr == "Minal load")
            {
                // .. minimal load
            }
            switch (analysisTypeStr)
            {
                case "Safety factor":
                    {
                        // .. calc for analysis type Safety factor
                        break;
                    }
                default:
                    break;
            }
        }

        private static void IntExample()
        {
            int analysisTypeInt = 0; // 0 .. Safety factor

            if (analysisTypeInt == 0)
            {
                // .. calc for analysis type 0
            }
            else if (analysisTypeInt == 1)
            {
                // .. calc for analysis type 1
            }
            else if (analysisTypeInt == 2)
            {
                // ..  calc for analysis type 2
            }

            switch (analysisTypeInt)
            {
                case 0:
                    {
                        // .. calc for analysis type 0
                        break;
                    }
                case 1:
                    {
                        // .. calc for analysis type 1
                        break;
                    }
                case 2:
                    {
                        // .. calc for analysis type 2
                        break;
                    }
                default:
                    break;
            }
        }
        #endregion
        public static void AsyncAwait()
        {
            /*

    Sync:
    public void DoSomething()
    {
        ... some things
        return;
    }

    Async:
    public async Task DoSomething()
    {
        ... some things
        await Task.WhenAll();
    }

    Sync:
    public int DoSomething()
    {
        ... some things
        return 3;
    }

    Async:
    public async Task<int> DoSomething()
    {
        ... some things
        await Task.WhenAll();
        return 3;
    }

    Asynchronní spuštění metody:
    await Task.Run( () => Metoda()  )

    */
        }

        void DictionaryWork()
        {

            Dictionary<int, string> people = new Dictionary<int, string>
            {
                {0, "Mirek" },
                {1, "Sabina" }
            };


            people.Add(2, "David");

            // Looping:

            foreach (KeyValuePair<int, string> person in people)
            {
                int key = person.Key;
                string value = person.Value;
            }


            // TODO: Jak změnit ve smyčce itemy v Dictionu?

        }

        public static void ClassCastingAndOverriding()
        {
            Cat cat1 = new Cat();
            Dog dog1 = new Dog();
            Cat cat2 = new Cat();
            Cat cat3 = new Cat();
            Dog dog2 = new Dog();
            List<Animal> animals = new List<Animal>();
            animals.Add(cat1);
            animals.Add(cat2);
            animals.Add(cat3);
            animals.Add(dog1);
            animals.Add(dog2);

            foreach (Animal animal in animals)
            {
                animal.MakeNoise();

                if (animal is Cat)  // animal.GetType() == typeof(Cat)
                {
                    Cat cat = (Cat)animal;
                    cat.CatchMouse();
                }
                else if (animal is Dog)
                {
                    Dog dog = (Dog)animal;
                    dog.MavatOcasem();
                }
            }
        }
    }
}
