using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCar : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Car(Clone)")
        {
            collision.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

}
