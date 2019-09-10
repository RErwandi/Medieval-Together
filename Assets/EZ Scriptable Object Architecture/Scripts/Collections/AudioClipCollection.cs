using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "AudioClipCollection.asset",
	    menuName = EZScriptableObjectUtility.ADD_COMPONENT_MENU_ROOT + EZScriptableObjectUtility.COLLECTION_SUBMENU + "AudioClip",
	    order = EZScriptableObjectUtility.ASSET_MENU_ORDER_COLLECTIONS)]
	public class AudioClipCollection : Collection<AudioClip>
	{
	}
}