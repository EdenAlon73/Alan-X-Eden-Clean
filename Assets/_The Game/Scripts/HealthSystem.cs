using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class HealthSystem :MonoBehaviour
{
    private float health;

    private int healthMax;
    
    
    void Awake()
    {
        GameEvents.Current.onDealHealth += Heal;
    }


    private void OnDisable()
    {
        GameEvents.Current.onDealHealth -= Heal;
    }

    public HealthSystem(int healthMax)
    {
        this.healthMax = healthMax;
        health = healthMax;
    }
    

    public float GetHealth()
    {
        return health;
    }

    public float GetHealthpercent()
    {
        return (float)health / healthMax;
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount * Time.deltaTime;
        if (health < 0)
        {
            health = 0;
        }
        
    }

    public void Heal(int healAmount)
    {
        health += healAmount;
        if (health > healthMax)
        {
            health = healthMax;
        }
    }
}
