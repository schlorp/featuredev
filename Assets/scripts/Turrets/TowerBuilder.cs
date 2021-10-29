using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private TowerBuildUI _buildUI;
    [SerializeField] private LayerMask _layer;
    private Tile _selectedTile = null;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && _selectedTile == null)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;

            if(Physics.Raycast(ray, out Hit, Mathf.Infinity, _layer))
            {
                Tile tile = Hit.transform.GetComponent<Tile>();
                if (!tile.HasTower&& tile._isBuildable)
                {
                    _selectedTile = tile;
                    _buildUI.Show(true);
                }
                else
                {
                    //sound
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _selectedTile != null)
        {
            _buildUI.Show(false);
            _selectedTile = null;
        }
    }

    public void BuildTower(Turret turret)
    {
        if (_selectedTile.HasTower&& !_selectedTile._isBuildable)
        {
            print("has tower");
            return;
        }

        Vector3 SpawnPOS = new Vector3(_selectedTile.transform.position.x, .5f, _selectedTile.transform.position.z);
        Instantiate(turret, SpawnPOS, Quaternion.identity, transform);
        _buildUI.Show(false);
        _selectedTile.HasTower = true;
        _selectedTile = null;
    }
}
