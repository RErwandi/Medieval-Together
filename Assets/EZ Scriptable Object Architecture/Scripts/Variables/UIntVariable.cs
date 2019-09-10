using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "UnsignedIntVariable.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "uint",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public class UIntVariable : BaseVariable<uint>
    {
    } 
}