using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "Vector2GameEvent.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.GAME_EVENT_SUBMENU + "Structs/Vector2",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_EVENTS)]
    public sealed class Vector2GameEvent : GameEventBase<Vector2>
    {
    } 
}