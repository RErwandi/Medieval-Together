using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reynold.Interaction
{
    public class ResourceInteraction : MonoBehaviour
    {
        public string resourceName;
        public int resourceAmount;
        
        public void AddResource()
        {
            Debug.Log("Interact with " + name + ". Adding resource for " + resourceName + " : " + resourceAmount);
        }
    }
}