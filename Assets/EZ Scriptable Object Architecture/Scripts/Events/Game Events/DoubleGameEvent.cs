using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "DoubleGameEvent.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.GAME_EVENT_SUBMENU + "double",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_EVENTS)]
    public sealed class DoubleGameEvent : GameEventBase<double>
    {
    } 
}