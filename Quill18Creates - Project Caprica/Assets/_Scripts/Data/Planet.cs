using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Caprica
{

    public class PlanetGraphic
    {
        //int, string, sprite, texture, model, who knows
        //animation Data?
    }

    public enum PlanetType { Asteroid, GasGiant, IceGiant, Continental, Gaian, Oceanic, Barren, Irradiated, Toxic, Desert, Arid, Tundra }
    public enum PlanetSize { Tiny, Small, Medium, Large, Huge }
    public enum PlanetRichness { VeryPoor, Poor, Abundant, Rich, VeryRich}
    //Planet Traits Might become a class that can Apply its own logic
    public enum PlanetTrait { GoldDeposit, ArtifactWorld }

    public class Planet 
	{

        public PlanetGraphic PlanetGraphic;

        public string Name;

        public readonly int PlanetIndex;  

        public PlanetType PlanetType;

        public PlanetSize PlanetSize;

        public PlanetRichness PlanetRichness;

        

        List<PlanetTrait> PlanetTraits;

        public Colony Colony;

    }

}