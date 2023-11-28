using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnSlideReach : MonoBehaviour
{
   // public float threshold = 0.02f;
    //public Transform target;
    public UnityEvent OnReached;
    private bool wasReached = false;


    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Detected (Trigger) " + other.gameObject.name);
        if (other.gameObject.name == "TriggerCube")
        wasReached = true;
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {

      
        if (wasReached)
        {
            wasReached = false;   
            //Reached target
            OnReached.Invoke();
     
        }
        
        /*
        float distance = Vector3.Distance(transform.position, target.position);
        

        Debug.Log("Distance = " + distance);


        *//*   if (distance < 0.9)
           {
               Debug.Log("Distance reached ");
           }*//*

        if (distance < threshold && !wasReached)
        {
            Debug.Log("Reached! " + distance + " " + threshold);
            wasReached = true;
            //Reached target
            OnReached.Invoke();
        }*/
     /*   else if (distance >= threshold)
        {
            wasReached = false;
        }*/
    }
}
