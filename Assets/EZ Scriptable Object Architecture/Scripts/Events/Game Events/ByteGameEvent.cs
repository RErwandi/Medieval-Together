using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "ByteGameEvent.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.GAME_EVENT_SUBMENU + "byte",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_EVENTS)]
    public sealed class ByteGameEvent : GameEventBase<byte>
    {
    } 
}