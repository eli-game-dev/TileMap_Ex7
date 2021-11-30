using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TunnelAndMove : MonoBehaviour
{
    [SerializeField] Tilemap tilemap = null;
    [SerializeField] TileTunnel tileTunnel = null;
    public TileBase grass;
    private float offsetTile = 0.15f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X) && Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 newPositionCheck = transform.position + Vector3.left * offsetTile;
            Vector3 newPosition = transform.position + Vector3.left * Time.deltaTime * tileTunnel.GetSpeedTunnel();
            Vector3Int cellPosition = tilemap.WorldToCell(newPositionCheck);
            Vector3Int cuurentCellPosition = tilemap.WorldToCell(transform.position);
            if (tileTunnel.Contain(tilemap.GetTile(cellPosition))||tileTunnel.Contain(tilemap.GetTile(cuurentCellPosition)))
            {
                transform.position = newPosition;
                tileTunnel.SetLifeOfTile(tileTunnel.GetLifeOfTile() - tileTunnel.GetSpeedTunnel());
                if (tileTunnel.GetLifeOfTile() <= 0)
                {
                    tilemap.SetTile(tilemap.WorldToCell(transform.position), grass);
                    tileTunnel.SetLifeOfTile(tileTunnel.GetRestlife());
                }
            }
        }
        else if (Input.GetKey(KeyCode.X) && Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 newPositionCheck = transform.position + Vector3.right * offsetTile;
            Vector3 newPosition = transform.position + Vector3.right * Time.deltaTime * tileTunnel.GetSpeedTunnel();
            Vector3Int cellPosition = tilemap.WorldToCell(newPositionCheck);
            Vector3Int cuurentCellPosition = tilemap.WorldToCell(transform.position);
            if (tileTunnel.Contain(tilemap.GetTile(cellPosition))||tileTunnel.Contain(tilemap.GetTile(cuurentCellPosition)))
            {
                transform.position = newPosition;
                tileTunnel.SetLifeOfTile(tileTunnel.GetLifeOfTile() - tileTunnel.GetSpeedTunnel());
                if (tileTunnel.GetLifeOfTile() <= 0)
                {
                    tilemap.SetTile(tilemap.WorldToCell(transform.position), grass);
                    tileTunnel.SetLifeOfTile(tileTunnel.GetRestlife());
                }
            }
        }
        else if (Input.GetKey(KeyCode.X) && Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 newPositionCheck = transform.position + Vector3.down * offsetTile;
            Vector3 newPosition = transform.position + Vector3.down * Time.deltaTime * tileTunnel.GetSpeedTunnel();
            Vector3Int cellPosition = tilemap.WorldToCell(newPositionCheck);
            Vector3Int cuurentCellPosition = tilemap.WorldToCell(transform.position);
            if (tileTunnel.Contain(tilemap.GetTile(cellPosition))||tileTunnel.Contain(tilemap.GetTile(cuurentCellPosition)))
            {
                transform.position = newPosition;
                tileTunnel.SetLifeOfTile(tileTunnel.GetLifeOfTile() - tileTunnel.GetSpeedTunnel());
                if (tileTunnel.GetLifeOfTile() <= 0)
                {
                    tilemap.SetTile(tilemap.WorldToCell(transform.position), grass);
                    tileTunnel.SetLifeOfTile(tileTunnel.GetRestlife());
                }
            }
        }
        else if (Input.GetKey(KeyCode.X) && Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 newPositionCheck = transform.position + Vector3.up * offsetTile;
            Vector3 newPosition = transform.position + Vector3.up * Time.deltaTime * tileTunnel.GetSpeedTunnel();
            Vector3Int cellPosition = tilemap.WorldToCell(newPositionCheck);
            Vector3Int cuurentCellPosition = tilemap.WorldToCell(transform.position);
            if (tileTunnel.Contain(tilemap.GetTile(cellPosition))||tileTunnel.Contain(tilemap.GetTile(cuurentCellPosition)))
            {
                transform.position = newPosition;
                tileTunnel.SetLifeOfTile(tileTunnel.GetLifeOfTile() - tileTunnel.GetSpeedTunnel());
                if (tileTunnel.GetLifeOfTile() <= 0)
                {
                    tilemap.SetTile(tilemap.WorldToCell(transform.position), grass);
                    tileTunnel.SetLifeOfTile(tileTunnel.GetRestlife());
                }
            }
        }
    }
}