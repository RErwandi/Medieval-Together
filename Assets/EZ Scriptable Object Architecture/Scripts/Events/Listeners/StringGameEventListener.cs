using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [AddComponentMenu(EZScriptableObjectUtility.EVENT_LISTENER_SUBMENU + "string Event Listener")]
    public sealed class StringGameEventListener : BaseGameEventListener<string, StringGameEvent, StringUnityEvent>
    {
    }
}