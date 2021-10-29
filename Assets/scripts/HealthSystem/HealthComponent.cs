using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private float _startHealth;

    private float _currentHealth;
    public float currentHealth
    {
        get { return _currentHealth; }
    }

    void Awake()
    {
        _currentHealth = _startHealth;
    }

    public void TakeDamage(float amount)
    {
        _currentHealth -= amount;
        HandelTakeDamage();
        if (_currentHealth <= 0)
        {
            Death();
        }
    }

    protected virtual void HandelTakeDamage()
    {
        Debug.Log("damage");
    }

    protected virtual void Death()
    {
        Debug.Log("i died");
    }

    public float GetNormalizedHealth()
    {
        return 5;
    } 
}
