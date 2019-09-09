using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "UnsignedShortVariable.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU +"ushort",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public class UShortVariable : BaseVariable<ushort>
    {
    } 
}