using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ObjectVariable.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "Object",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public class ObjectVariable : BaseVariable<Object>
    {
    } 
}