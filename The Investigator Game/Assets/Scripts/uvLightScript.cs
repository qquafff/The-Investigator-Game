using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uvLightScript : MonoBehaviour
{

    public GameObject go1;
    public GameObject go2;
    public GameObject go3;
    public GameObject go4;
    public GameObject go5;
    public GameObject go6;

    public flashlightScript flashLight;

    public Collider lightSourceCollider;
    characterController charCtrl;

    private bool lightOnFingerprint = false;

    public MeshRenderer rend;

    public Light lightS;
    public GameObject lightSource;

    void Start()
    { 
        charCtrl = GetComponent<characterController>();
        rend = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(flashLight.FlashOn == true)
        {
            go1.SetActive(true);
        }
        else if (flashLight.FlashOn == false)
        {
            go1.SetActive(false);
        }

    }

    /*void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FingerPrint")
        {
           
                
                other.gameObject.SetActive(true);
               
        }    
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "FingerPrint")
        {
            other.gameObject.SetActive(false);
        }
    }*/
}
