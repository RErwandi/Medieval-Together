using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [AddComponentMenu(EZScriptableObjectUtility.EVENT_LISTENER_SUBMENU + "short Event Listener")]
    public sealed class ShortGameEventListener : BaseGameEventListener<short, ShortGameEvent, ShortUnityEvent>
    {
    }
}