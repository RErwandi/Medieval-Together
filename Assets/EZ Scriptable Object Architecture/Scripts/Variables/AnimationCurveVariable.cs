using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "AnimationCurveVariable.asset",
	    menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "AnimationCurve",
	    order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
	public class AnimationCurveVariable : BaseVariable<AnimationCurve>
	{
	}
}