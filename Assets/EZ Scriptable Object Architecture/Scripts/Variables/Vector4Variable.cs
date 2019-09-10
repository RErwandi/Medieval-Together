using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "Vector4Variable.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "Structs/Vector4",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public sealed class Vector4Variable : BaseVariable<Vector4>
    {
    } 
}