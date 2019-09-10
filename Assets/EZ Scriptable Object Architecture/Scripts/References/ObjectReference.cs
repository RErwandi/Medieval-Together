using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [System.Serializable]
    public class ObjectReference : BaseReference<Object, ObjectVariable>
    {
        public ObjectReference() : base() { }
        public ObjectReference(Object value) : base(value) { }
    } 
}