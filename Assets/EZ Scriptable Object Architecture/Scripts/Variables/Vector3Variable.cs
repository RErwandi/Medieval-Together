using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "Vector3Variable.asset",
        menuName =EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "Structs/Vector3",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public sealed class Vector3Variable : BaseVariable<Vector3>
    {
    } 
}