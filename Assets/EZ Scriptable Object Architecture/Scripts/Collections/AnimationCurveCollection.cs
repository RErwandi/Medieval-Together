using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "AnimationCurveCollection.asset",
	    menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.COLLECTION_SUBMENU + "AnimationCurve",
	    order = EZScriptableObjectUtility.ASSET_MENU_ORDER_COLLECTIONS)]
	public class AnimationCurveCollection : Collection<AnimationCurve>
	{
	}
}