using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "SignedByteGameEvent.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.GAME_EVENT_SUBMENU + "sbyte",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_EVENTS)]
    public sealed class SByteGameEvent : GameEventBase<sbyte>
    {
    } 
}