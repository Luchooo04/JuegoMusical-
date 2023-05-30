using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorNivel : MonoBehaviour
{
    public Texture2D mapa; 
    public ColorAPrefab[] colorMappings; 
    
    void Start() 
    { 
        GenerarNivel(); 
    }

    private void GenerarNivel()
    {
        for (int x = 0; x < mapa.width; x++)
        {
            for (int y = 0; y < mapa.height; y++)
            {
                GenerarTile(x, y);
            }
        }
    }

    void GenerarTile(int x, int y) 
    {
        Color pixelColor = mapa.GetPixel(x, y);
        if (pixelColor.a == 0)
        { 
            return; 
        }
        
        foreach (ColorAPrefab colorMapping in colorMappings) 
        {
            if (colorMapping.color.Equals(pixelColor)) 
            {
                Vector2 position = new Vector2(x, y);
                Instantiate(colorMapping.prefab, position, Quaternion.identity, transform);
            }
        }
    }
   
    [System.Serializable]
    public class ColorAPrefab
    {
        public Color color;
        public GameObject prefab;
    }
}
