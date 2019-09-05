using UnityEngine;

namespace Reynold.Medieval
{
    public enum ModificationType {Add, Subtract}
    public class ResourceInteraction : MonoBehaviour
    {
        public ResourceType resourceType;
        public ModificationType modification;
        public int resourceAmount;
        
        public void AddResource()
        {
            var amount = resourceAmount;
            if (modification == ModificationType.Subtract)
                amount = -amount;
            ResourcesManager.Instance.AddResource(resourceType, amount);
        }
    }
}