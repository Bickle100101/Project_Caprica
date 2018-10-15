using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Caprica
{
	public static class Config 
	{
        // Value are Coded here for now, but the goal is to load in from a config file
        //that is moddable

        public static int GetInt(string parameter)
        {
            switch (parameter)
            {
                case "PLANET_MAX_POPULATION_Tiny":
                    return 4;
                case "PLANET_MAX_POPULATION_Small":
                    return 6;
                case "PLANET_MAX_POPULATION_Medium":
                    return 10;
                case "PLANET_MAX_POPULATION_Large":
                    return 12;
                case "PLANET_MAX_POPULATION_Huge":
                    return 16;
                default:
                    Debug.LogError("Config::GetInt() - No Option for Parameter: " + parameter);
                    return 0;
            }
        }
		
	}
}