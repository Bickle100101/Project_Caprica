using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Caprica
{

    public class StarSystemGraphic
    {
        //int, string, sprite, texture, model, who knows
        //animation Data?
    }

	public class StarSystem 
	{
        public StarSystem()
        {
            Planets = new Planet[MAX_PLANETS];

            //GeneratePlanets();
            
        }

        private const int MAX_PLANETS = 6;

        private Planet[] planets;

        int starType;       //0 = Yellow, Positive = Older/Les Rich, negative = Younger/Less Habitable

        public StarSystemGraphic StarSystemGraphic;

        public string Name;

        public Planet GetPlanet(int PlanetIndex)
        {
            return planets[PlanetIndex];
        }

        private void GeneratePlanets()
        {
            //Generate 0 to max Planets
            //Weightingh planet Class Based on StarType + distance from Sun
        }
		
	}
}