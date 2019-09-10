using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "Color32Variable.asset",
	    menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "Structs/Color32",
	    order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
	public class Color32Variable : BaseVariable<Color32>
	{
	}
}