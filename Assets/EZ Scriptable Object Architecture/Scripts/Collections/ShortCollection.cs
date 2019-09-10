using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ShortCollection.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.COLLECTION_SUBMENU + "short",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_COLLECTIONS)]
    public class ShortCollection : Collection<short>
    {
    } 
}