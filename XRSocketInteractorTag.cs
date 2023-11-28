using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRSocketInteractorTag : XRSocketInteractor
{
 
    //public string targetTag;
    [SerializeField] private string tag;
    

    public override bool CanSelect(XRBaseInteractable interactable)
    {

        Debug.Log("XRInteractor CanSelect");
        return base.CanSelect(interactable) && interactable.CompareTag(tag);
    }

}
