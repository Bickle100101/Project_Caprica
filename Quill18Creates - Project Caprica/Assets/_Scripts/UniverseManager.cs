using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Caprica;



public class UniverseManager : MonoBehaviour 
{

    //This Script is Responsible for holding Main data Object
    //Triggering File Saves/Loads or triggering Galaxy generation

    //Maybe also gets callbacks from end turn

    Galaxy galaxy;

	void Start () 
	{
        Generate();
	}

	void Update () 
	{
			
	}
		
    public void Generate()
    {
        Debug.Log("UniverseManager::Generate - Generating a New Galaxy");

        galaxy = new Galaxy();
        galaxy.Generate();
    }
}
