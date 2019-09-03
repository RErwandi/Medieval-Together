using TMPro;
using UnityEngine;

namespace Reynold.InventorySystem
{
    public class InteractText : MonoBehaviour
    {
        public RectTransform canvasRect;
        public GameObject target;

        private Camera mainCamera;
        
        
        void Start()
        {
            mainCamera = Camera.main;
        }

        void Update()
        {
            if (target == null)
                return;
            
            // Offset position above object bbox (in world space)
            var position = target.transform.position;

            // Final position of marker above GO in world space
            Vector3 offsetPos = new Vector3(position.x, position.y, position.z);
 
            // Calculate *screen* position (note, not a canvas/recttransform position)
            Vector2 canvasPos;
            Vector2 screenPoint = mainCamera.WorldToScreenPoint(offsetPos);
 
            // Convert screen position to Canvas / RectTransform space <- leave camera null if Screen Space Overlay
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRect, screenPoint, null, out canvasPos);
 
            // Set
            transform.localPosition = canvasPos;
        }
    }
}