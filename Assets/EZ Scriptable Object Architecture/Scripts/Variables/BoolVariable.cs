using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "BoolVariable.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "bool",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public sealed class BoolVariable : BaseVariable<bool>
    {
    } 
}