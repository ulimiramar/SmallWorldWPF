using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Dieta;
using SmallWorld.src.Model.Habitat;
using SmallWorld.src.Model.Reino;
using SmallWorld.src.UI.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Static
{
    static class InterfacesImplementations
    {
        static Random random = new Random();
        private static List<IKingdom>kingdomsAvailables=new List<IKingdom>()
        {
            new Alien(), new Animal(), new Machine(), new Vegetable()
        };
        private static List<IDiet> dietsAvailables = new List<IDiet>()
        {
            new Carnivorous(), new Omnivorous(), new Herbivorous()
        };
        private static List<IHabitat> habitatsAvailables = new List<IHabitat>()
        {
            new Terrestrial(), new Aerial(), new Aquatic()
        };

        public static List<IKingdom> KingdomsAvailables { get => kingdomsAvailables; set => kingdomsAvailables = value; }
        public static List<IDiet> DietsAvailables { get => dietsAvailables; set => dietsAvailables = value; }
        public static List<IHabitat> HabitatsAvailables { get => habitatsAvailables; set => habitatsAvailables = value; }
        
        
        public static List<IHabitat> GetRandomHabitatList()
        {
            int maxCount = HabitatsAvailables.Count;
            int count = random.Next(1, maxCount + 1);
            List<IHabitat> shuffledHabitats = HabitatsAvailables.OrderBy(x => random.Next()).ToList();
            List<IHabitat> randomHabitatList = shuffledHabitats.Take(count).ToList();
            return randomHabitatList;
        }
        public static List<IDiet> GetRandomDietList()
        {
            int maxCount = DietsAvailables.Count;
            int count = random.Next(1, maxCount + 1);
            List<IDiet> shuffledDiets = DietsAvailables.OrderBy(x => random.Next()).ToList();
            List<IDiet> randomDietList = shuffledDiets.Take(count).ToList();
            return randomDietList;
        }
        public static IKingdom GetRandomKingdom()
        {
            int randomIndex = random.Next(0, KingdomsAvailables.Count);
            return KingdomsAvailables[randomIndex];
        }
        public static IDiet GetRandomDiet()
        {
            int randomIndex = random.Next(0, DietsAvailables.Count);
            return DietsAvailables[randomIndex];
        }
    }
}
