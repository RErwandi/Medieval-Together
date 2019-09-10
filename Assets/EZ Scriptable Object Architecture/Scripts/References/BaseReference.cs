using System.Collections;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

namespace EZ.ScriptableObjectArchitecture
{
    [System.Serializable]
    public class BaseReference<TBase, TVariable> : BaseReference where TVariable : BaseVariable<TBase>
    {
        public BaseReference() { }
        public BaseReference(TBase baseValue)
        {
            useConstant = true;
            constantValue = baseValue;
        }

        [ValueDropdown("ConstantOrVar", AppendNextDrawer = false)]
        [HorizontalGroup("Group References")][HideLabel][SerializeField]
        protected bool useConstant = false;
        [HorizontalGroup("Group References")][HideLabel][ShowIf("useConstant")][SerializeField]
        protected TBase constantValue = default(TBase);
        [HorizontalGroup("Group References")][HideLabel][HideIf("useConstant")][SerializeField]
        protected TVariable variable = default(TVariable);

        private IEnumerable ConstantOrVar = new ValueDropdownList<bool>()
        {
            {"Use Constant", true},
            {"Use Variable", false}
        };
        
        public TBase Value
        {
            get
            {
                return (useConstant || variable == null) ? constantValue : variable.Value;
            }
            set
            {
                if (!useConstant && variable != null)
                {
                    variable.Value = value;
                }
                else
                {
                    useConstant = true;
                    constantValue = value;
                }
            }
        }
        public bool IsValueDefined
        {
            get
            {
                return useConstant || variable != null;
            }
        }

        public BaseReference CreateCopy()
        {
            BaseReference<TBase, TVariable> copy = (BaseReference<TBase, TVariable>)System.Activator.CreateInstance(GetType());
            copy.useConstant = useConstant;
            copy.constantValue = constantValue;
            copy.variable = variable;

            return copy;
        }
        public void AddListener(IGameEventListener listener)
        {
            if (variable != null)
                variable.AddListener(listener);
        }
        public void RemoveListener(IGameEventListener listener)
        {
            if (variable != null)
                variable.RemoveListener(listener);
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }

    //Can't get property drawer to work with generic arguments
    public abstract class BaseReference { } 
}