using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "ObjectGameEvent.asset",
        menuName =EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.GAME_EVENT_SUBMENU + "Object",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_EVENTS)]
    public class ObjectGameEvent : GameEventBase<Object>
    {
    } 
}