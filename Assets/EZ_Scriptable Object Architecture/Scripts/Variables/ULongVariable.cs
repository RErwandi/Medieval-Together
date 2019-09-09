using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "UnsignedLongVariable.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "ulong",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public class ULongVariable : BaseVariable<ulong>
    {
    } 
}