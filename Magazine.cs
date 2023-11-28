using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magazine : MonoBehaviour
{
    public int numberOfBullets = 8;


    public void SentToOtherDiminsion()
    {
        this.gameObject.layer = LayerMask.NameToLayer("OtherDiminsion");

       foreach (Transform child in transform)
        {
            child.gameObject.layer = LayerMask.NameToLayer("OtherDiminsion");
        }
        
    }

    public void DropMagChangeTag()
    {
        Debug.Log("DropMagChangeTag");
        this.tag = "trigger";
    }


     
}
