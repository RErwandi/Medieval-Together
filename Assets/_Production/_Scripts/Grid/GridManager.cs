using UnityEngine;

namespace Reynold.Medieval
{
    public class GridManager : PersistentSingleton<GridManager>
    {
        [SerializeField] private Vector2 gridArea = Vector2.zero;
        [SerializeField] private float gridSize = 1f;
        [SerializeField] private GameObject gridPrefab = null;
        [SerializeField] private GameObject gridHighlight = null;
        
        private GridArea currentGridArea = null;
        private GridArea[,] gridsArea;
        private Transform player;
        private GameObject highlighter;
        private Vector3 gridPos;
        private int gridX;
        private int gridZ;
        
        public GridArea CurrentGrid
        {
            get => currentGridArea;
            private set => currentGridArea = value;
        }

        protected override void Awake()
        {
            base.Awake();
            gridsArea = new GridArea[(int)gridArea.x, (int)gridArea.y];
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        private void Start()
        {
            SpawnGrid();
            highlighter = Instantiate(gridHighlight, this.transform);
        }

        private void Update()
        {
            gridPos = GetNearestPointOnGrid(player.position);
            gridPos.y = 0.1f;
            gridX = (int)(gridPos.x / gridSize);
            gridZ = (int)(gridPos.z / gridSize);
            
            if (gridX >= 0 && gridX < gridArea.x && gridZ >= 0 && gridZ < gridArea.y)
            {
                highlighter.transform.position = gridPos;
                CurrentGrid = gridsArea[gridX, gridZ];
            }
        }

        private void SpawnGrid()
        {
            for (int i = 0; i < gridArea.x; i++)
            {
                for (int j = 0; j < gridArea.y; j++)
                {
                    Vector3 pos = new Vector3(i * gridSize, 0.01f, j * gridSize);
                    GameObject grid = Instantiate(gridPrefab, pos, gridPrefab.transform.rotation, this.transform);
                    grid.name = "Grid [" + i + "," + j + "]";
                    GridArea area = grid.GetComponent<GridArea>();
                    gridsArea[i, j] = area;
                }
            }
            
            for (int i = 0; i < gridArea.x; i++)
            {
                for (int j = 0; j < gridArea.y; j++)
                {
                    GridArea currentArea = gridsArea[i, j];

                    if (i > 0)
                    {
                        var leftAdjacent = gridsArea[i - 1, j];
                        currentArea.AddAdjacentGrid(leftAdjacent);
                    }

                    if (i < gridArea.x - 1)
                    {
                        var rightAdjacent = gridsArea[i + 1, j];
                        currentArea.AddAdjacentGrid(rightAdjacent);
                    }
                    
                    if (j > 0)
                    {
                        var topAdjacent = gridsArea[i, j - 1];
                        currentArea.AddAdjacentGrid(topAdjacent);
                    }

                    if (j < gridArea.y - 1)
                    {
                        var botAdjacent = gridsArea[i, j + 1];
                        currentArea.AddAdjacentGrid(botAdjacent);
                    }
                }
            }
        }

        private Vector3 GetNearestPointOnGrid(Vector3 position)
        {
            position -= transform.position;

            int xCount = Mathf.RoundToInt(position.x / gridSize);
            int yCount = Mathf.RoundToInt(position.y / gridSize);
            int zCount = Mathf.RoundToInt(position.z / gridSize);

            Vector3 result = new Vector3(
                xCount * gridSize,
                yCount * gridSize,
                zCount * gridSize);
            result += transform.position;
            return result;
        }
    }
}