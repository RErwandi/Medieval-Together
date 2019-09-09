using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ByteVariable.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "byte",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public class ByteVariable : BaseVariable<byte>
    {
    } 
}