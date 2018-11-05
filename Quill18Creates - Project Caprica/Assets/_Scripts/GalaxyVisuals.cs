using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Caprica;

public class GalaxyVisuals : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}

    public LayerMask ClickableStarsLayerMask;

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonUp(0))
        {
            //mouse was clicked .  is it on a star

            //ToDo  ignore clicks if over UI elements

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, ClickableStarsLayerMask))
            {
                //we hit something that can only be a clickable star

                ClickableStar cs = hitInfo.collider.GetComponentInParent<ClickableStar>();

                if (cs == null)
                {
                    Debug.LogError(" Star does not have a ClickableStar component");
                    return;
                }

                Debug.Log("Clicked Star :" + cs.name);

                ViewManager.Instance.ShowView(ViewManager.Instance.SystemView);
            }

        }


	}

    public GameObject[] StarPrefabs;  //index of Array is Star Type. prefabs are responsible for for
                                      // Appearance Variety

    Galaxy galaxy;

    public void InitiateVisuals(Galaxy galaxy)
    {
        this.galaxy = galaxy;

        for (int i = 0; i < galaxy.GetNumStarSystems(); i++)
        {
            StarSystem ss = galaxy.GetStarSystem(i);

            GameObject go = Instantiate(
                        StarPrefabs[ss.GetStarTypeIndex()],
                        ss.Position,        //will this need to multiply by a scaler
                        Quaternion.identity,
                        this.transform
                        );

        }
    }
}
