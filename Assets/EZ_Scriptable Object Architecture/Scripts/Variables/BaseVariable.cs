using System;
using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    public abstract class BaseVariable : GameEventBase
    {
    }
    
    public abstract class BaseVariable<T> : BaseVariable
    {
        public T Value
        {
            get => value;
            set
            {
                this.value = SetValue(value);
                Raise();
            }
        }
        public virtual Type Type => typeof(T);
        public virtual object BaseValue
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

        public T SetValue(T value)
        {
            return value;
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