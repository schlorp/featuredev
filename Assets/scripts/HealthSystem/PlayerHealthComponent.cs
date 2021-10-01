using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthComponent : HealthComponent
{
    [SerializeField] PlayerHealthUI PHUI;

    private void Start()
    {
        PHUI.updateUI(currentHealth);
    }

    protected override void Death()
    {
        base.Death();
        Debug.Log("speler is door");
    }

    protected override void HandelTakeDamage()
    {
        base.HandelTakeDamage();
        PHUI.updateUI(currentHealth);
    }

}
