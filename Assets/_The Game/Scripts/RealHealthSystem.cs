using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RealHealthSystem : MonoBehaviour
{
    public Slider healthSlider;

    public int maxHealth;

    public float currentHealth;

    public float damageAmount;

    public float healAmount;


    private void Awake()
    {
        GameEvents.Current.onHeal += Heal;

        currentHealth = maxHealth;
    }

    public void OnDisable()
    {
        GameEvents.Current.onHeal -= Heal;
    }

    private void Update()
    {
        DealDamage();

        UpdateHealthSlider();
    }

    public void DealDamage()
    {
        currentHealth -= damageAmount * Time.deltaTime;
    }

    public void UpdateHealthSlider()
    {
        healthSlider.value = currentHealth;
    }

    public void Heal()
    {
        currentHealth += healAmount;
    }



































}
