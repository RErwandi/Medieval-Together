using UnityEngine;

namespace Reynold.Resource
{
    public enum ResourceType {Wood, Stone}
    
    [CreateAssetMenu(menuName = "Medieval/Resource", fileName = "Resource", order = 0)]
    public class ResourceItem : ScriptableObject
    {
        public ResourceType type;
        public string resourceName;
        public Sprite icon;
    }
}