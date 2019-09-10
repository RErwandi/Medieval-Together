using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [AddComponentMenu(EZScriptableObjectUtility.EVENT_LISTENER_SUBMENU + "Quaternion Event Listener")]
    public sealed class QuaternionGameEventListener : BaseGameEventListener<Quaternion, QuaternionGameEvent, QuaternionUnityEvent>
    {
    }
}