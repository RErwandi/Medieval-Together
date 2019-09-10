using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [AddComponentMenu(EZScriptableObjectUtility.EVENT_LISTENER_SUBMENU + "byte Event Listener")]
    public sealed class ByteGameEventListener : BaseGameEventListener<byte, ByteGameEvent, ByteUnityEvent>
    {
    }
}