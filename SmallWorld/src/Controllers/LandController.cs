using SmallWorld.src.Interfaces;
using SmallWorld.src.Model.Map;
using SmallWorld.src.Model.Terrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWorld.src.Controllers
{
    internal class LandController
    {
        private static LandController instance;
        private readonly List<Land> Lands = new List<Land>();
        private LandController() { }
        public static LandController GetInstance()
        {
            if (instance == null)
            {
                instance = new LandController();
            }
            return instance;
        }
        public void AddLand(ITerrainType terrainType)
        {
            Land LandToAdd = new Land(terrainType);
            Lands.Add(LandToAdd);
        }
        public void AddBorderingLands(Land landToModify, List<Land> BorderingLandsToAdd)
        {
            foreach(Land land in BorderingLandsToAdd) 
            {
                landToModify.BorderingLands.Add(land);
            }
        }
        public void AddBorderingLand(Land landToModify, Land BorderingLandToAdd)
        {
            landToModify.BorderingLands.Add(BorderingLandToAdd);
        }
        public List<Land> getLands()
        {
            return Lands;
        }

        public List<IPositionable> getPositionbalesInAllLands()
        {
            List<IPositionable> allPositionables = new List<IPositionable>();
            foreach (Land land in Lands)
            {
                allPositionables.AddRange(land.Positionables);
            }
            return allPositionables;
        }

        public List<Land> getBorderingLands(Land land)
        {
            return land.BorderingLands;
        }
        public void Update(Land landToModify, Land landModified)
        {

            int index = Lands.FindIndex(e => e == landToModify);

            if (index != -1)
            {
                Lands[index] = landModified;
            }
        }

        //TODO: para que sea escalable podría pasarle el parámetro "mapa" a esta función
        public void setBorderingLands()
        {
            var random = new Random();
            
            foreach (Land land in Lands)
            {
                //cantidad de tierras limitrofes entre 1 y 6
                int numBorderingLands = random.Next(1, 7);
                //Trae todos los indices de las tierras disponibles
                List<int> availableLandIndices = Enumerable.Range(0, Lands.Count).ToList();
                // Elimina el índice de la tierra actual de las tierras disponibles para que no limite con ella misma
                availableLandIndices.Remove(Lands.IndexOf(land));

                for (int i = 0; i < numBorderingLands; i++)
                {
                    if (availableLandIndices.Count > 0)
                    {
                        //elige aleatoriamente una tierra entre las tierras limitrofes
                        int randomIndex = random.Next(0, availableLandIndices.Count);
                        //asigna a una variable entera el indice de la tierra.
                        int borderingLandIndex = availableLandIndices[randomIndex];
                        // Verifica si la tierra limitrofe ya ha sido agregada y si no exceden ninguna de las dos tierras el límite de tener 6 límitrofes
                        if (!land.BorderingLands.Contains(Lands[borderingLandIndex]) && land.BorderingLands.Count < 6 && Lands[borderingLandIndex].BorderingLands.Count < 6)
                        {
                            // Agrega la tierra limitrofe y visceversa
                            AddBorderingLand(land, Lands[borderingLandIndex]);
                            AddBorderingLand(Lands[borderingLandIndex], land);

                        }
                    }
                }
            }
        }

    }
}
