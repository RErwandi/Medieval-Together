using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [AddComponentMenu(EZScriptableObjectUtility.EVENT_LISTENER_SUBMENU + "double Event Listener")]
    public sealed class DoubleGameEventListener : BaseGameEventListener<double, DoubleGameEvent, DoubleUnityEvent>
    {
    }
}