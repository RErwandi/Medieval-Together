using EZ.ScriptableObjectArchitecture;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Reynold.Medieval
{
    public class PlayerInteraction : MonoBehaviour
    {
        [SerializeField] private GameObjectVariable interactableObject = default;
        [SerializeField] private GameEvent onAbleInteract = default;
        [SerializeField] private GameEvent onUnableInteract = default;

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
            interactableObject.Value = interactable.gameObject;
            onAbleInteract.Raise();
        }

        private void OnTriggerExit(Collider other)
        {
            var interactable = other.GetComponentInParent<Interactable>();
            if (interactable == null)
                return;
            if (interactableObject.Value == interactable.gameObject)
            {
                interactableObject.Value = null;
                onUnableInteract.Raise();
            }
        }

        private void TryInteract()
        {
            if(interactableObject.Value != null)
            {
                interactableObject.Value.GetComponent<Interactable>().onInteract.Invoke();
            }
        }
    }
}