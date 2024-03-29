using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class ColorReference : BaseReference<Color, ColorVariable>
	{
	    public ColorReference() : base() { }
	    public ColorReference(Color value) : base(value) { }
	}
}