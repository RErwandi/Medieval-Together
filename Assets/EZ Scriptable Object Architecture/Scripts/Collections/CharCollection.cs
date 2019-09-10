using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "CharCollection.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.COLLECTION_SUBMENU + "char",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_COLLECTIONS)]
    public class CharCollection : Collection<char>
    {
    } 
}