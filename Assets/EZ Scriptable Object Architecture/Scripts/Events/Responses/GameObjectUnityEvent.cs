using UnityEngine;
using UnityEngine.Events;

namespace EZ.ScriptableObjectArchitecture
{
    [System.Serializable]
    public sealed class GameObjectUnityEvent : UnityEvent<GameObject>
    {
    } 
}