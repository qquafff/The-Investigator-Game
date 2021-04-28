using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SlamDoor : MonoBehaviour
{
    DoorScript ds;
    public AudioSource audioData;
    public GameObject door;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
       
        {
            audioData.Play(0);
            
            Debug.Log("Osuttu");
            Destroy(this.gameObject);
        }
    }
}
