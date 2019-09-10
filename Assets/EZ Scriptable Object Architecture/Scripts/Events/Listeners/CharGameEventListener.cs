using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [AddComponentMenu(EZScriptableObjectUtility.EVENT_LISTENER_SUBMENU + "char Event Listener")]
    public sealed class CharGameEventListener : BaseGameEventListener<char, CharGameEvent, CharUnityEvent>
    {
    }
}