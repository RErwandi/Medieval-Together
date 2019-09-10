using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "FloatVariable.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "float",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public class FloatVariable : BaseVariable<float>
    {
    } 
}