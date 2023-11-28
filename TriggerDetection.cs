using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection : MonoBehaviour
{
    private void OnCollisionEntered(Collision collision)
    {
        //if (collision.gameObject.tag == "trigger")
            Debug.Log("Slider Collision detection. Slider is moved back");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter " +  other.gameObject.name);
    }
}
