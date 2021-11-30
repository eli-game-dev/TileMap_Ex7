using System.Data;
using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * This component allows the player to move by clicking the arrow keys,
 * but only if the new position is on an allowed tile.
 */
public class KeyboardMoverByTile : KeyboardMover
{
    [SerializeField] Tilemap tilemap = null;
    [SerializeField] AllowedTiles allowedTiles = null;
    [SerializeField] TileSpeed tileSpeed = null;

    [SerializeField] float speed = 5f;
    //private Vector3 offsetD;


    private TileBase TileOnPosition(Vector3 worldPosition)
    {
        Vector3Int cellPosition = tilemap.WorldToCell(worldPosition);
        return tilemap.GetTile(cellPosition);
    }

    protected Vector3 NewPosition()
    {
        TileBase tilePosition = TileOnPosition(transform.position);
        float currentSpeed;
        if (tileSpeed.Contain(tilePosition))
        {
            currentSpeed = tileSpeed.GetSpeed(tilePosition);
        }
        else
        {
            currentSpeed = speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // offsetD = new Vector3(-offset,0);
            return transform.position + Vector3.left * Time.deltaTime * currentSpeed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //  offsetD = new Vector3(offset,0);
            return transform.position + Vector3.right * Time.deltaTime * currentSpeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            // offsetD = new Vector3(0,-offset);
            return transform.position + Vector3.down * Time.deltaTime * currentSpeed;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            //  offsetD = new Vector3(0,offset);
            return transform.position + Vector3.up * Time.deltaTime * currentSpeed;
        }
        else
        {
            return transform.position;
        }
    }

    void Update()
    {
        Vector3 newPosition = NewPosition();
        //  TileBase tileOnNewPosition = TileOnPosition(newPosition+offsetD);
        TileBase tileOnNewPosition = TileOnPosition(newPosition);
        if (allowedTiles.Contain(tileOnNewPosition))
        {
            transform.position = newPosition;
        }
        else
        {
            Debug.Log("You cannot walk on " + tileOnNewPosition + "!");
        }
    }
}