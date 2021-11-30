using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileSpeed : MonoBehaviour
{
    
   // [SerializeField] Dictionary<TileBase,float> tilesSpeed = null;
    [SerializeField] TileBase[] tilesSpeed = null;
    [SerializeField] float[] walkingSpeedPerTileIndex;
    
    public bool Contain(TileBase tile) {
        return  tilesSpeed.Contains(tile);
    }

    public float GetSpeed(TileBase tile)
    {
        int index = Array.IndexOf(tilesSpeed, tile);
        return walkingSpeedPerTileIndex[index];
    }
}
