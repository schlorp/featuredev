using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    [SerializeField]private float _speed;
    [SerializeField] private float _arrivalThreshold;
    private Path _path;
    private Waypoint _currentWaypoint;

    private void Start()
    {
        SetupPath();
    }

    void SetupPath()
    {
        _path = FindObjectOfType<Path>();
        _currentWaypoint = _path.GetPathStart();
        transform.LookAt(_currentWaypoint.GetPosition());
    }
    private void Update()
    {
        
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        float DistanceToWaypoint = Vector3.Distance(transform.position, _currentWaypoint.GetPosition());
        Waypoint End = _path.GetPathEnd();

        if(DistanceToWaypoint <= _arrivalThreshold)
        {
            if(_path.GetPathEnd() == _currentWaypoint)
            {
                PathComplete();
            }
            else
            {
                _currentWaypoint = _path.GetNextWaypoint(_currentWaypoint);
                transform.LookAt(_currentWaypoint.GetPosition());
            }
        }

        
    }
    void PathComplete()
    {
        Destroy(gameObject);
    }
}
