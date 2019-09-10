using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "Color32Collection.asset",
	    menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.COLLECTION_SUBMENU + "Structs/Color32",
	    order = EZScriptableObjectUtility.ASSET_MENU_ORDER_COLLECTIONS)]
	public class Color32Collection : Collection<Color32>
	{
	}
}