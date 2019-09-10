using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "ColorVariable.asset",
	    menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "Structs/Color",
	    order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
	public class ColorVariable : BaseVariable<Color>
	{
	}
}