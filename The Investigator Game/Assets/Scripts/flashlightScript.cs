using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class flashlightScript : MonoBehaviour
{

    public bool FlashOn = false;
    public GameObject lightSource;
    public bool failSafe = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("FKey"))
        {
            if (FlashOn == false && failSafe == false)
            {
                failSafe = true;
                lightSource.SetActive(true);
                FlashOn = true;
                StartCoroutine(FailSafe());
            }
            if (FlashOn == true && failSafe == false)
            {
                failSafe = true;
                lightSource.SetActive(false);
                FlashOn = false;
                StartCoroutine(FailSafe());
            }
        }
    }

    IEnumerator FailSafe()
    {
        yield return new WaitForSeconds(0.25f);
        failSafe = false;
    }
}
