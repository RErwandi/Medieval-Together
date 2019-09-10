using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "ColorCollection.asset",
	    menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.COLLECTION_SUBMENU + "Structs/Color",
	    order = EZScriptableObjectUtility.ASSET_MENU_ORDER_COLLECTIONS)]
	public class ColorCollection : Collection<Color>
	{
	}
}