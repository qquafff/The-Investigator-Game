using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public GameObject objectToAddForce;
    public Rigidbody rb;
    public float power;
    public float x;
    public float y;
    public float z;
    public Vector3 myVector;

    void Start()
    {
        myVector = new Vector3(x, y, z);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        { 
            
            rb.AddRelativeForce(myVector * power);
            Debug.Log("Osuttu");
            Destroy(this.gameObject);
        }
    }


}
