using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject blockPrefab;
    public Vector2Int gridSize = new Vector2Int(12, 5);
    public Vector2 offset = new Vector2(1.2f, 0.6f);

    void Start()
    {
        // ancho y alto total de la cuadrícula
        float gridWidth = (gridSize.x - 1) * offset.x;
        float gridHeight = (gridSize.y - 10) * offset.y;

        // esta es la posición inicial para centrar
        Vector2 startPosition = new Vector2(-gridWidth / 2f, -gridHeight / 2f);

        for (int row = 0; row < gridSize.y; row++)
        {
            for (int col = 0; col < gridSize.x; col++)
            {
                Vector2 position = startPosition + new Vector2(col * offset.x, row * offset.y);
                Instantiate(blockPrefab, position, Quaternion.identity);
            }
        }
    }
}
