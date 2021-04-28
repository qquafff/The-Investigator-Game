using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseGravity : MonoBehaviour
{
    public GameObject objectToAddForce;
    public Rigidbody rb;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            rb.useGravity = true;
        }
    }
}
