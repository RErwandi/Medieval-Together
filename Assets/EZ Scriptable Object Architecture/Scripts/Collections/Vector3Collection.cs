using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "Vector3Collection.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.COLLECTION_SUBMENU + "Structs/Vector3",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_COLLECTIONS)]
    public class Vector3Collection : Collection<Vector3>
    {
    } 
}