using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casing : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Casing has collided");
        StartCoroutine(AddtoPool());
   
       
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Casing has triggered");
        StartCoroutine(AddtoPool());
    }

    private IEnumerator AddtoPool()
    {
        Debug.Log("Casing Add To Pool Called!!");
        //Deactivate Bullet and addto pool
        yield return new WaitForSeconds(5.0f);
        gameObject.SetActive(false);
        SimpleShoot.Instance.AddCasingToPool(this);
    }

    //Getting the transform to reset transform for collider
    public void CasingSetActive(Transform transform)
    {
        gameObject.SetActive(true);
        gameObject.transform.position = transform.position;
        
    }
}
