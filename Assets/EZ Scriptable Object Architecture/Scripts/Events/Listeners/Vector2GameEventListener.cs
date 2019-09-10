using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [AddComponentMenu(EZScriptableObjectUtility.EVENT_LISTENER_SUBMENU + "Vector2 Event Listener")]
    public sealed class Vector2GameEventListener : BaseGameEventListener<Vector2, Vector2GameEvent, Vector2UnityEvent>
    {
    }
}