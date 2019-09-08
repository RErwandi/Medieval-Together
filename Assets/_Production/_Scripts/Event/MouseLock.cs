using UnityEngine;

namespace Reynold.Medieval
{
    /// <summary>
    /// MouseLockEvent used to tell if we should lock the cursor or not
    /// </summary>
    public struct MouseLockEvent
    {
        public bool lockCursor;
        public MouseLockEvent(bool lockCursor)
        {
            this.lockCursor = lockCursor;
        }

        private static MouseLockEvent e;

        public static void Trigger(bool lockCursor)
        {
            e.lockCursor = lockCursor;
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
            switch (eventType.lockCursor)
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