using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject blockPrefab;
    public Vector2Int gridSize = new Vector2Int(12, 5);
    public Vector2 offset = new Vector2(1.2f, 0.6f);
    
    // los colores de las filass
    public Color[] rowColors = new Color[]
    {
        new Color(1f, 0f, 0f),      // Rojo
        new Color(1f, 0.5f, 0f),    // Naranja
        new Color(1f, 1f, 0f),      // Amarillo
        new Color(0f, 1f, 0f),      // Verde
        new Color(0f, 0.5f, 1f)     // Azul
    };

    void Start()
    {
        float gridWidth = (gridSize.x - 1) * offset.x;
        float gridHeight = (gridSize.y - 10) * offset.y;
        Vector2 startPosition = new Vector2(-gridWidth / 2f, -gridHeight / 2f);

        for (int row = 0; row < gridSize.y; row++)
        {
            // Obtener el color para esta fila
            Color rowColor = rowColors[row % rowColors.Length];
            
            for (int col = 0; col < gridSize.x; col++)
            {
                Vector2 position = startPosition + new Vector2(col * offset.x, row * offset.y);
                GameObject block = Instantiate(blockPrefab, position, Quaternion.identity);
                
                // Asignar el color al bloque
                SpriteRenderer sr = block.GetComponent<SpriteRenderer>();
                if (sr != null)
                {
                    sr.color = rowColor;
                }
            }
        }
    }
}
