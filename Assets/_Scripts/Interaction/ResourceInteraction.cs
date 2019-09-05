using UnityEngine;

namespace Reynold.Medieval
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