using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "GameObjectCollection.asset",
        menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.COLLECTION_SUBMENU + "GameObject",
        order = EZScriptableObjectUtility.ASSET_MENU_ORDER_COLLECTIONS)]
    public class GameObjectCollection : Collection<GameObject>
    {
    } 
}
