using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "IntVariable.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "int",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public class IntVariable : BaseVariable<int>
    {
    } 
}