using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "SByteVariable.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "sbyte",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public class SByteVariable : BaseVariable<sbyte>
    {
    } 
}