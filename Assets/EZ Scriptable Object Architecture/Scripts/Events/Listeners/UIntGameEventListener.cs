using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [AddComponentMenu(EZScriptableObjectUtility.EVENT_LISTENER_SUBMENU + "uint Event Listener")]
    public sealed class UIntGameEventListener : BaseGameEventListener<uint, UIntGameEvent, UIntUnityEvent>
    {
    }
}