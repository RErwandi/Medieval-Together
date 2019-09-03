using UnityEngine;

namespace Reynold.Resource
{
    [CreateAssetMenu(menuName = "Medieval/Resource", fileName = "Resource", order = 0)]
    public class Resource : ScriptableObject
    {
        public string sku;
        public string resourceName;
        public Sprite icon;
        public int quantity;
        public int maxStack;
        
        public Resource Copy()
        {
            string name = this.name;
            Resource clone = UnityEngine.Object.Instantiate(this);
            clone.name = name;
            return clone;
        }
    }
}