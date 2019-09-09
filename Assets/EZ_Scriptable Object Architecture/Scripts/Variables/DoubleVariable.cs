using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "DoubleVariable.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "double",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public class DoubleVariable : BaseVariable<double>
    {
    } 
}