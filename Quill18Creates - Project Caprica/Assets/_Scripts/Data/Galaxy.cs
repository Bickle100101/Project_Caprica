using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Caprica
{

    public static class GalaxyConfig
    {
        //Gets Filled out by some kind of "New Game" Screen
        //Used by Generate Function to tune Game Parameters

        public static int NumPlayers = 8;
        public static int NumStars = 50;


        //Total Width/Height allowed for Star System generation
        public static int GalaxyWidth = 100;

        // Consider reading the defaults from a config file
    }

    public class Galaxy : MonoBehaviour
    {
        int galaxyWidth = GalaxyConfig.GalaxyWidth;

        public GameObject starPrefab;

        public Galaxy()
        {
            StarSystems = new List<StarSystem>();
        }

        private List<StarSystem> StarSystems;

        public StarSystem GetStarSystem(int starSystemId)
        {
            return StarSystems[starSystemId];
        }

        public void Generate()
        {
            //Just make some random Stars on the screen

            for (int i = 0; i < GalaxyConfig.NumStars; i++)
            {
                StarSystem ss = new StarSystem();
                ss.Position = new Vector3
                    (
                        Random.Range(-galaxyWidth / 2, galaxyWidth / 2),
                        Random.Range(-galaxyWidth / 2, galaxyWidth / 2),
                        0
                    );

                ss.Generate(/* Galactic Age/richness info?  What Kinds of Stars to Generate? Consider Player Starting PLanets?*/);

                //GameObject starGO = 
                GameObject.Instantiate(starPrefab, ss.Position, Quaternion.identity, this.transform);
                StarSystems.Add(ss);
            }

            Debug.Log(" Number of Stars (numStars) Generated: " + StarSystems.Count);
        }
	}
}