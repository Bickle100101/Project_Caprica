using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ViewManager : MonoBehaviour 
{

    public GalaxyVisuals GalaxyVisuals;
    public SystemView SystemView;


    public static ViewManager Instance { get; protected set; }


    private void OnEnable()
    {
        Instance = this;
    }


    void Start () 
	{
		
	}

	void Update () 
	{

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            //back out of views one step at a time
            //if in master view (Galaxy), open game menu
        }
	}

    public void ShowView(MonoBehaviour viewComponent)
    {
        viewComponent.gameObject.SetActive(true);
    }

    public void HideView(MonoBehaviour viewComponent)
    {
        viewComponent.gameObject.SetActive(false);
    }
}