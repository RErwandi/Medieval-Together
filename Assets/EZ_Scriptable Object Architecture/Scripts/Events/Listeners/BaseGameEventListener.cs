using UnityEngine;
using UnityEngine.Events;

namespace EZ.ScriptableObjectArchitecture
{
    public abstract class BaseGameEventListener<TType, TEvent, TResponse> : MonoBehaviour, IGameEventListener<TType>
        where TEvent : GameEventBase<TType>
        where TResponse : UnityEvent<TType>
    {
        [SerializeField] private TEvent gameEvent = default;
        [SerializeField] private TResponse response = default;
        
        private void OnEnable()
        {
            if (gameEvent != null)
            {
                gameEvent.AddListener(this);
            }
        }

        private void OnDisable()
        {
            if (gameEvent != null)
            {
                gameEvent.RemoveListener(this);
            }
        }

        public void OnEventRaised(TType value)
        {
            response.Invoke(value);
        }
    }
    
    public abstract class BaseGameEventListener<TEvent, TResponse> : MonoBehaviour, IGameEventListener
        where TEvent : GameEventBase
        where TResponse : UnityEvent
    {
        [SerializeField] private TEvent gameEvent = default;
        [SerializeField] private TResponse response = default;

        private void OnEnable()
        {
            if (gameEvent != null)
            {
                gameEvent.AddListener(this);
            }
        }

        private void OnDisable()
        {
            if (gameEvent != null)
            {
                gameEvent.RemoveListener(this);
            }
        }

        public void OnEventRaised()
        {
            response.Invoke();
        }
    }
}