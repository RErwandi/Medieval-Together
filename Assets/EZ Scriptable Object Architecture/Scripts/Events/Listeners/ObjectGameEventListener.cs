using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [AddComponentMenu(EZScriptableObjectUtility.EVENT_LISTENER_SUBMENU + "Object Event Listener")]
    public class ObjectGameEventListener : BaseGameEventListener<Object, ObjectGameEvent, ObjectUnityEvent>
    {
    }
}