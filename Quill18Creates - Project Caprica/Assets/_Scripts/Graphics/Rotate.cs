using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Caprica
{
    [ExecuteInEditMode]
    public class Rotate : MonoBehaviour 
	{
        public Vector3 RotationSpeed = new Vector3(0, 30, 0);

        private void Update()
        {
            this.transform.Rotate(RotationSpeed * Time.deltaTime);
        }




    }   

}