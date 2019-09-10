using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ShortVariable.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "short",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public class ShortVariable : BaseVariable<short>
    {
    } 
}