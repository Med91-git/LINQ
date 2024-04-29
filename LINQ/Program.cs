using System.Collections.Generic;
using static LINQ.Program;

namespace LINQ
{
    internal class Program
    {

        public class AnimalContext 
        {
            public List<Animal> Animals { get; set; }
            public List<Species> Species { get; set; }
            
        }

        public class Animal
        {
            public int AnimalId { get; set; }
            public String Name { get; set; }
            public DateTime DateOfBirth { get; set; } 
            public Species Species { get; set; }
        }

        public class Species
        {
            public int SpeciesId { get; set; }
            public String Name { get; set; } 
        }

        static void Main(string[] args)
        {
            var context = new AnimalContext();
            //Instancier les listes d'espèces et d'animaux

            context.Animals = new List<Animal>();
            context.Species = new List<Species>();


            // Instancier chaque espece de l'animal et l'ajouter dans la listes des espèces

            Species whiteCougars = new Species();

            whiteCougars.SpeciesId = 1;
            whiteCougars.Name = "Cougars Blancs";

            context.Species.Add(whiteCougars);

            Species whiteTigers = new Species();

            whiteTigers.SpeciesId = 2;
            whiteTigers.Name = "Tigres Blancs";
            context.Species.Add(whiteTigers);

            Species albinoTurtles = new Species();

            albinoTurtles.SpeciesId = 3;
            albinoTurtles.Name = "Tortues Albinos";
            context.Species.Add(albinoTurtles);


            // Définir le nombre total des animaux disponible selon l'espèce  

            const int whiteCougarsNumber = 3;
            const int whiteTigersNumber = 100;
            const int albinoTurtlesNumber = 15;

            // Instancier et ajouter l'animal dans la liste des animaux en fonction de son espèce  

            for (int i = 0; i < whiteCougarsNumber; i++)
            {
                var animal = new Animal();
                animal.Name = "Cougars Blancs";
                animal.Species = whiteCougars;

                context.Animals.Add(animal);

                
            }
            // en fonction de l'espece de l'animal (attribut nom ou id de l'espèce) ->  afficher le nombre d'animaux 

            var whiteCougarSpecies = context.Species.Where((s) => s.Name == "Cougars Blancs");
            IEnumerable<Animal> cougars = context.Animals.Where((a) => a.Species == whiteCougars); 

            int cougarsCount = cougars.Count(); 
            Console.WriteLine("nombre de cougars blancs : " + cougarsCount); 

            

            for (int i = 0; i < whiteTigersNumber; i++)
            {

                var animal = new Animal();
                animal.Name = "Tigres Blancs";
                animal.Species = whiteTigers;

                context.Animals.Add(animal); 

            }

            var whiteTigersSpecies = context.Species.Where((s) => s.Name == "Cougars Blancs");
            IEnumerable<Animal> tigers = context.Animals.Where((a) => a.Species == whiteTigers);

            int tigersCount = tigers.Count();
            Console.WriteLine("nombre de tigres blancs : " + tigersCount); 

            for (int i = 0; i < albinoTurtlesNumber; i++)
            {

                var animal = new Animal();
                animal.Name = "Tortues Albinos";
                animal.Species = albinoTurtles;

                context.Animals.Add(animal);

            }
            var albinoturtlesSpecies = context.Species.Where((s) => s.Name == "Cougars Blancs");
            IEnumerable<Animal> turtles = context.Animals.Where((a) => a.Species == albinoTurtles);

            int turtlesCount = turtles.Count();
            Console.WriteLine("nombre de tortues albinos : " + turtlesCount); 













        }
    }
}
