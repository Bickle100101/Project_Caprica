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
            
        }

        public Vector3 Position;

        private const int MAX_PLANETS = 6;

        private Planet[] Planets;

        int starType;       //0 = Yellow, Positive = Older/Les Rich, negative = Younger/Less Habitable

        public StarSystemGraphic StarSystemGraphic;

        public string Name;

        public Planet GetPlanet(int PlanetIndex)
        {
            return Planets[PlanetIndex];
        }

        public void Generate(int starType = 0 /* Galactic Age/Richness info?  Perhaps Specific PLanet Generation?  Consider PLayer Starting Planets */)
        {
            this.starType = starType;

        
            //generate Planets
        }

        //private void GeneratePlanets(/* Galactic Age/richness info?  What Kinds of Stars to Generate? Consider Player Starting PLanets?*/)
        //{
        //    //Generate 0 to max Planets
        //    //Weightingh planet Class Based on StarType + distance from Sun
        //}

        public void Load(/* some kind fo File Handle?*/)
        {

        }

        public void Save( /* some kind of File handle?*/)
        {

        }

    }
}