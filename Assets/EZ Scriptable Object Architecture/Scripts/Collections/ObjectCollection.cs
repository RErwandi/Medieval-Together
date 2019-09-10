using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ObjectCollection.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.COLLECTION_SUBMENU + "Object",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_COLLECTIONS)]
    public class ObjectCollection : Collection<Object>
    {
    } 
}