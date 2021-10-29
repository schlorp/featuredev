using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField]
    private bool _isWaypoint;


    public Vector3 GetPosition()
    {
        return transform.position + new Vector3(0,.25f,0);
    }
}
