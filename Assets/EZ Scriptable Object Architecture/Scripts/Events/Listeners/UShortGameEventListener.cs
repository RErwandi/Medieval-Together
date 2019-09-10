using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [AddComponentMenu(EZScriptableObjectUtility.EVENT_LISTENER_SUBMENU + "ushort Event Listener")]
    public sealed class UShortGameEventListener : BaseGameEventListener<ushort, UShortGameEvent, UShortUnityEvent>
    {
    }
}