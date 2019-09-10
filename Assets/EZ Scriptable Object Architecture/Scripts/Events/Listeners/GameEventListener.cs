using UnityEngine;
using UnityEngine.Events;

namespace EZ.ScriptableObjectArchitecture
{
    [AddComponentMenu(EZScriptableObjectUtility.EVENT_LISTENER_SUBMENU + "Game Event Listener")]
    [ExecuteInEditMode]
    public sealed class GameEventListener : BaseGameEventListener<GameEventBase, UnityEvent>
    {
    }
}