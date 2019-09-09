using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "LongVariable.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "long",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public class LongVariable : BaseVariable<long>
    {
    } 
}