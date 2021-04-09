using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class flashlightScript : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;
    public GameObject go3;
    public GameObject go4;
    public GameObject go5;
    
    public bool FlashOn = false;
    public GameObject lightSource;
    public bool failSafe = false;

    // Update is called once per frame
    void Update()
    {
        //Checks if F is pressed and tests if failsafe doesn't prevent turning the flashlight on or off. At the moment works as the flashlight and the UV Light
        if (Input.GetButtonDown("FKey"))
        {
            if (FlashOn == false && failSafe == false)
            {
                failSafe = true;
                lightSource.SetActive(true);
                FlashOn = true;
                go1.SetActive(true);
                go2.SetActive(true);
                go3.SetActive(true);
                go4.SetActive(true);
                go5.SetActive(true);
                
                StartCoroutine(FailSafe());
            }
            if (FlashOn == true && failSafe == false)
            {
                failSafe = true;
                lightSource.SetActive(false);
                FlashOn = false;
                go1.SetActive(false);
                go2.SetActive(false);
                go3.SetActive(false);
                go4.SetActive(false);
                go5.SetActive(false);
                
                StartCoroutine(FailSafe());
            }
        }
    }
     //The failsafe mechanism
    IEnumerator FailSafe()
    {
        yield return new WaitForSeconds(0.25f);
        failSafe = false;
    }
}
