using Sirenix.OdinInspector;
using UnityEngine;

namespace Reynold.Medieval
{
    public enum InteractionType {Enter, Exit}
    
    /// <summary>
    /// InteractionEvent used to tell when player interacting with something
    /// </summary>
    public struct InteractionEvent
    {
        public Interactable interactable;
        public InteractionType type;
        
        public InteractionEvent(Interactable interactable, InteractionType type)
        {
            this.interactable = interactable;
            this.type = type;
        }

        private static InteractionEvent e;
    
        public static void Trigger(Interactable interactable, InteractionType type)
        {
            e.interactable = interactable;
            e.type = type;
            EventManager.TriggerEvent(e);
        }
    }
    
    public class PlayerInteraction : MonoBehaviour
    {
        [ReadOnly] [ShowInInspector] private Interactable interactableObject;

        private MyInputAction input;

        private void OnEnable()
        {
            input.Player.Interact.performed += ctx => TryInteract();
            input.Player.Interact.Enable();
        }

        private void OnDisable()
        {
            input.Player.Interact.Disable();
        }

        private void Awake()
        {
            input = new MyInputAction();
        }

        private void OnTriggerEnter(Collider other)
        {
            var interactable = other.GetComponentInParent<Interactable>();
            if (interactable == null)
                return;
            interactableObject = interactable;
            InteractionEvent.Trigger(interactable, InteractionType.Enter);
        }

        private void OnTriggerExit(Collider other)
        {
            interactableObject = null;
            InteractionEvent.Trigger(null, InteractionType.Exit);
        }

        void TryInteract()
        {
            if(interactableObject != null)
                interactableObject.onInteract.Invoke();
        }
    }
}