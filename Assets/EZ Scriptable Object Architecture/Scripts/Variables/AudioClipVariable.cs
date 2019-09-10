using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "AudioClipVariable.asset",
	    menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.VARIABLE_SUBMENU + "AudioClip",
	    order = EZScriptableObjectUtility.ASSET_MENU_ORDER_VARIABLES)]
	public class AudioClipVariable : BaseVariable<AudioClip>
	{
	}
}