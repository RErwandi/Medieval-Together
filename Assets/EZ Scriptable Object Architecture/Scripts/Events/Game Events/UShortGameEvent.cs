using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "UnsignedShortGameEvent.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.GAME_EVENT_SUBMENU + "ushort",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_EVENTS)]
    public sealed class UShortGameEvent : GameEventBase<ushort>
    {
    } 
}