using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "GameObjectVariable.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "GameObject",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
    public sealed class GameObjectVariable : BaseVariable<GameObject>
    {
    } 
}