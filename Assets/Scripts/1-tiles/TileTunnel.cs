using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;


public class TileTunnel : MonoBehaviour
{
    [SerializeField] TileBase[] tilesTunnel = null;
    [SerializeField] float speedTunnel = 0.1f;
    private float restlife;
    [SerializeField] private float lifeOfTile = 50f;

    private void Start()
    {
        restlife = lifeOfTile;
    }

    public bool Contain(TileBase tile) {
        return  tilesTunnel.Contains(tile);
    }
    
    public float GetSpeedTunnel()
    {
        return speedTunnel;
    }
    public float GetLifeOfTile()
    {
        return lifeOfTile;
    }
    public float GetRestlife()
    {
        return restlife;
    }
    public void SetLifeOfTile(float _lifeOfTile)
    {
        this.lifeOfTile = _lifeOfTile;
    }
}
