using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace EZ.ScriptableObjectArchitecture
{
    public abstract class GameEventBase<T> : GameEventBase, IGameEvent<T>
    {
        private readonly List<IGameEventListener<T>> typedListeners = new List<IGameEventListener<T>>();
        [SerializeField] private T debugValue = default(T);

        [Button(ButtonSizes.Medium)]
        void DebugRaise()
        {
            foreach (var typedListener in typedListeners)
            {
                typedListener.OnEventRaised(debugValue);
            }

            foreach (var listener in Listeners)
            {
                listener.OnEventRaised();
            }
        }
        
        public void Raise(T value)
        {
            foreach (var typedListener in typedListeners)
            {
                typedListener.OnEventRaised(value);
            }

            foreach (var listener in Listeners)
            {
                listener.OnEventRaised();
            }
        }

        public void AddListener(IGameEventListener<T> listener)
        {
            if (!typedListeners.Contains(listener))
                typedListeners.Add(listener);
        }

        public void RemoveListener(IGameEventListener<T> listener)
        {
            if (typedListeners.Contains(listener))
                typedListeners.Remove(listener);
        }
    }

    public abstract class GameEventBase : ScriptableObject, IGameEvent
    {
        protected readonly List<IGameEventListener> Listeners = new List<IGameEventListener>();

        [Button(ButtonSizes.Medium)]
        void DebugRaise()
        {
            foreach (var listener in Listeners)
            {
                listener.OnEventRaised();
            }
        }
        
        public void Raise()
        {
            foreach (var listener in Listeners)
            {
                listener.OnEventRaised();
            }
        }

        public void AddListener(IGameEventListener listener)
        {
            if (!Listeners.Contains(listener))
                Listeners.Add(listener);
        }

        public void RemoveListener(IGameEventListener listener)
        {
            if (Listeners.Contains(listener))
                Listeners.Remove(listener);
        }

        public void RemoveAll()
        {
            Listeners.Clear();
        }
    }
}
