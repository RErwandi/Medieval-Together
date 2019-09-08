using UnityEngine;

namespace Reynold.Medieval
{
    public class InteractView : MonoBehaviour, IEventListener<InteractionEvent>
    {
        public RectTransform canvasRect;
        public GameObject interactObject;
        public GameObject target;

        private Camera mainCamera;

        private void OnEnable()
        {
            this.EventStartListening();
        }

        private void OnDisable()
        {
            this.EventStopListening();
        }

        void Start()
        {
            mainCamera = Camera.main;
            interactObject.SetActive(false);
        }

        void Update()
        {
            if (target == null)
            {
                return;
            }
                
            
            // Offset position above object (in world space)
            var position = target.transform.position;

            // Final position of marker above GO in world space
            Vector3 offsetPos = new Vector3(position.x, position.y, position.z);
 
            // Calculate *screen* position (note, not a canvas/recttransform position)
            Vector2 screenPoint = mainCamera.WorldToScreenPoint(offsetPos);
 
            // Convert screen position to Canvas / RectTransform space <- leave camera null if Screen Space Overlay
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRect, screenPoint, null, out var canvasPos);
 
            // Set
            transform.localPosition = canvasPos;
        }

        public void OnEvent(InteractionEvent eventType)
        {
            switch (eventType.type)
            {
                case InteractionType.Enter:
                    target = eventType.interactable.gameObject;
                    interactObject.SetActive(true);
                    break;
                case InteractionType.Exit:
                    target = null;
                    interactObject.SetActive(target != null);
                    break;
            }
        }
    }
}