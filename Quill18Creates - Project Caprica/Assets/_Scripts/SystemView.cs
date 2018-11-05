using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SystemView : MonoBehaviour 
{

	void Start () 
	{
        Instance = this;
        gameObject.SetActive(false);
	}

    static public SystemView Instance;

	void Update () 
	{
		
	}
	
}