using System.Collections.Generic;
using UnityEngine;

namespace Reynold.Medieval
{
    public enum GridState { Empty, Soil}
    
    public class GridArea : MonoBehaviour
    {
        [SerializeField] private Material soilMaterial = null;
        [SerializeField] private GridState state = GridState.Empty;

        public GridState State
        {
            get => state;
            set => state = value;
        }

        private List<GridArea> adjacentGrid = new List<GridArea>();
        private MeshRenderer mesh;
        private Renderer render;

        private void Awake()
        {
            mesh = GetComponent<MeshRenderer>();
            render = GetComponent<Renderer>();
        }

        public void DoAction()
        {
            switch (state)
            {
                case GridState.Empty:
                    state = GridState.Soil;
                    mesh.enabled = true;
                    ChangeMaterial(soilMaterial);
                    break;
            }
        }

        public void DoRemove()
        {
            state = GridState.Empty;
            mesh.enabled = false;
        }

        private void ChangeMaterial(Material mat)
        {
            render.material = mat;
        }

        public void AddAdjacentGrid(GridArea gridArea)
        {
            adjacentGrid.Add(gridArea);
        }
    }
}