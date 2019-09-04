using System.Collections;
using System.Collections.Generic;
using Reynold.Resource;
using UnityEngine;

namespace Reynold.Interaction
{
    public enum ModificationType {Add, Substract}
    public class ResourceInteraction : MonoBehaviour
    {
        public ResourceType resourceType;
        public ModificationType modification;
        public int resourceAmount;
        
        public void AddResource()
        {
            var amount = resourceAmount;
            if (modification == ModificationType.Substract)
                amount = -amount;
            ResourcesManager.Instance.AddResource(resourceType, amount);
        }
    }
}