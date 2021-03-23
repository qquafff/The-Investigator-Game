using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uvLightScript : MonoBehaviour
{
    
    

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray uvRay = new Ray(Vector3 origin, Vector3 direction);
        Physics.Raycast(UVRay, RaycastHit hitInfo, float distance, int LayerMask);
    }
}
