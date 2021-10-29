using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField]
    public bool _isBuildable;
    private Renderer Rr;
    private Color _DefaultColor;
    public Color HoverColor;

    public bool HasTower { get; set; }


    private void Start()
    {
        Rr = GetComponent<Renderer>();
        _DefaultColor = Rr.material.color;
    }

    public bool GetIsBuildable()
    {
        return _isBuildable;
    }

    private void OnMouseEnter()
    {
        if (_isBuildable)
        {
            Rr.material.color = HoverColor;
        }
    }

    private void OnMouseExit()
    {
        Rr.material.color = _DefaultColor;
    }

}
