using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider sliderHealth;
    private HealthSystem healthSystem;

    private void Awake()
    {
      //  GameEvents.Current.OnUpdateHealth += UpdateHealth;
    }

    private void OnDisable()
    {
       // GameEvents.Current.OnUpdateHealth -= UpdateHealth;
    }

    public void Setup(HealthSystem healthSystem)
    {
        this.healthSystem = healthSystem;
    }


   /* public void UpdateHealth()
    {
        sliderHealth.value = healthSystem.GetHealth();
    }*/

    private void Update()
    {
        sliderHealth.value = healthSystem.GetHealth();
    }
}
