using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Reynold.Resource
{
    public class ResourcesManager : MonoBehaviour
    {
        [SerializeField] private List<Resource> availableResource = new List<Resource>();

        public void AddResource(Resource resource, int quantity)
        {
            foreach (var r in availableResource.Where(r => r.sku == resource.sku))
            {
                Debug.Log("Adding " + quantity + " quantity to resource " + r.resourceName);
                r.quantity += quantity;
            }
        }

        private void Start()
        {
            
        }
    }
}