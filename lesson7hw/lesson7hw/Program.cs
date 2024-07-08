namespace lesson7hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            Rayon rayon = new Rayon();
            Olke olke = new Olke();

        }
        public class City {
            public string Name; 
            public int Territory;
            public int Numofpeople;
            public City() { 

            }
            public City(string name, int teritory, int people) { 
                Name = name;
                Territory = teritory;
                Numofpeople=people;

            }
        }
        public class Rayon {
            public string Name;
            public int Territory;
            public int Numofpeople;
            public double Budget;

            public Rayon() { 
            
            }
            public Rayon(string name,int territory)
            {
                Name = name;
                Territory=territory;
            }
            public Rayon(string name, int territory, int numofpeople, double budget) : this(name, territory)
            {
              
                Numofpeople = numofpeople;
                Budget = budget;
            }

        }
        public class Olke {
            public string Name;
            public int Territory;
            public int Numofpeople;
            public double Budget;
            public int Numbofarmy;
            public int Numbofcity;
            public Olke() { 
            
            }
            public Olke(string name, int territory, int numofpeople, double budget, int numbofarmy, int numbofcity)
            {
                Name = name;
                Territory = territory;
                Numofpeople = numofpeople;
                Budget = budget;
                Numbofarmy = numbofarmy;
                Numbofcity = numbofcity;
            }
        }
    }
}
