using System;
using System.Collections.Generic;
using System.Linq;
using Reynold.Tools;
using UnityEngine;

namespace Reynold.Resource
{
    [System.Serializable]
    public class Resource
    {
        public ResourceItem item;
        public int quantity;
        public int maxQuantity;
    }
    
    public class ResourcesManager : PersistentSingleton<ResourcesManager>
    {
        [SerializeField] private List<Resource> resources = new List<Resource>();

        public void AddResource(ResourceType type, int amount)
        {
            var idx = FindResourceIndexByType(type);
            var resource = resources[idx];
            resource.quantity += amount;

            Debug.Log("Adding resources " + resource.item.resourceName + ": " + amount);
        }

        private int FindResourceIndexByType(ResourceType type)
        {
            for (int i = 0; i < resources.Count; i++)
            {
                if (resources[i].item.type == type)
                {
                    return i;
                }
            }

            return -1;
        }

        private Resource FindResourceByType(ResourceType type)
        {
            foreach (var resource in resources.Where(resource => resource.item.type == type))
            {
                return resource;
            }

            Debug.LogError("No resources found with type " + type + ". Redirect it to first resource");
            return resources[0];
        }
    }
}