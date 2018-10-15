using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Caprica
{
	public class Colony 
	{

        public Planet Planet;

        int population { get { return popFarmers + popWorkers + popScientists; } }
        int popFarmers;
        int popWorkers;
        int popScientists;

        int flatProduction; //normally 0 unless special condition or tech applies
        int productionPerWorker;  //PlanetRichess/2 + 1

        //List<Building> BuiltBuildings;
        List<int> BuiltBuildingIndexes;
        List<int> BuildingBuiltTurn;

        public int TotalProductionPerTurn()
        {
            return flatProduction + (productionPerWorker * popWorkers);  
        }

        public void DoEndOfTurn()
        {
            //For Each Built Building call end fo turn update
            // and pass value of turn number it was built on
        }

        public int MaxPopulation()
        {
            int p = Config.GetInt("PLANET_MAX_POPULATION_" + Planet.PlanetSize.ToString());

            //Is Species Subterranian, or Have some other bonus to Population Cap
            //  Could also be from tech, for example MoO2's "City"
            //  or buildings like Biodomes
            //  or planet spacial trait

            return p;
        }
		
	}
}