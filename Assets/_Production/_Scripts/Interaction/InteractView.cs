using System;
using EZ.ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.Serialization;

namespace Reynold.Medieval
{
    public class InteractView : MonoBehaviour
    {
        public RectTransform canvasRect;
        [FormerlySerializedAs("interactObject")] public GameObject interactView;
        [SerializeField] private GameObjectVariable target = default;

        private Camera mainCamera;

        void Start()
        {
            mainCamera = Camera.main;
            interactView.SetActive(false);
        }

        void Update()
        {
            if (target.Value == null)
            {
                return;
            }
            
            // Offset position above object (in world space)
            var position = target.Value.transform.position;

            // Final position of marker above GO in world space
            Vector3 offsetPos = new Vector3(position.x, position.y, position.z);
 
            // Calculate *screen* position (note, not a canvas/recttransform position)
            Vector2 screenPoint = mainCamera.WorldToScreenPoint(offsetPos);
 
            // Convert screen position to Canvas / RectTransform space <- leave camera null if Screen Space Overlay
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRect, screenPoint, null, out var canvasPos);
 
            // Set
            transform.localPosition = canvasPos;
        }

        public void ShowInteractView()
        {
            interactView.SetActive(true);
        }

        public void HideInteractView()
        {
            interactView.SetActive(false);
        }
    }
}