﻿namespace EZ.ScriptableObjectArchitecture
{
    [System.Serializable]
    public sealed class FloatReference : BaseReference<float, FloatVariable>
    {
        public FloatReference() : base() { }
        public FloatReference(float value) : base(value) { }
    } 
}