using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Reynold.Medieval
{
    public class PlayerBuild : MonoBehaviour
    {
        [SerializeField] private bool buildMode = false;
        [SerializeField] private GameObject currentBuilding;
        [SerializeField] [ReadOnly] private GameObject previewBuilding;

        private void Start()
        {
            if (previewBuilding == null)
            {
                previewBuilding = new GameObject();
            }
            UpdatePreviewBuilding();
        }

        private void Update()
        {
            if (buildMode)
            {
                UpdatePositionPreviewBuilding();
            }
        }

        public void ChangeBuilding(GameObject building)
        {
            currentBuilding = building;
            DeleteAllChildPreviewBuilding();
            UpdatePreviewBuilding();
        }

        void DeleteAllChildPreviewBuilding()
        {
            while(previewBuilding.transform.childCount > 0){ 
                Destroy(previewBuilding.transform.GetChild(0).gameObject);  
            }
        }

        void UpdatePreviewBuilding()
        {
            GameObject preview = Instantiate(currentBuilding, previewBuilding.transform);
            preview.transform.localPosition = Vector3.zero;
            preview.transform.localScale = Vector3.one;
        }

        void UpdatePositionPreviewBuilding()
        {
            previewBuilding.transform.position = GridManager.Instance.CurrentGrid.transform.position;
        }
    }
}