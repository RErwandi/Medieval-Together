using System;
using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    public abstract class BaseVariable : GameEventBase
    {
        public abstract Type Type { get; }
        public abstract object BaseValue { get; set; }
    }
    public abstract class BaseVariable<T> : BaseVariable
    {
        public virtual T Value
        {
            get => value;
            set
            {
                this.value = SetValue(value);
                Raise();
            }
        }
        public override Type Type => typeof(T);
        public override object BaseValue
        {
            get => value;
            set
            {
                this.value = SetValue((T)value);
                Raise();
            }
        }

        [SerializeField]
        protected T value = default(T);

        public virtual T SetValue(T value)
        {
            return value;
        }
        public virtual T SetValue(BaseVariable<T> value)
        {
            return value.Value;
        }
        
        public override string ToString()
        {
            return value == null ? "null" : value.ToString();
        }
        
        public static implicit operator T(BaseVariable<T> variable)
        {
            return variable.Value;
        }
    } 
}