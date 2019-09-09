using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "QuaternionVariable.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "Structs/Quaternion",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public sealed class QuaternionVariable : BaseVariable<Quaternion>
    {
    } 
}