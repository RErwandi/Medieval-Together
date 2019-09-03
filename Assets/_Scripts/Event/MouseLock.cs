using UnityEngine;

namespace Reynold.Event
{
    public struct MouseLockEvent
    {
        public bool IsLock;
        public MouseLockEvent(bool b)
        {
            IsLock = b;
        }

        private static MouseLockEvent e;

        public static void Trigger(bool b)
        {
            e.IsLock = b;
            EventManager.TriggerEvent(e);
        }
    }
    public class MouseLock : MonoBehaviour, IEventListener<MouseLockEvent>
    {
        [SerializeField] private bool lockOnStart = false;

        private void OnEnable()
        {
            this.EventStartListening();
        }

        private void OnDisable()
        {
            this.EventStopListening();
        }

        private void Start()
        {
            if (lockOnStart)
                MouseLockEvent.Trigger(true);
        }

        public void OnEvent(MouseLockEvent eventType)
        {
            switch (eventType.IsLock)
            {
                case true:
                    Cursor.lockState = CursorLockMode.Locked;
                    break;
                case false:
                    Cursor.lockState = CursorLockMode.None;
                    break;
            }
        }
    }
}