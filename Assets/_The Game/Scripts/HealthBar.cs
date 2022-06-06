using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider sliderHealth;
    private HealthSystem healthSystem;
    
    
    public void Setup(HealthSystem healthSystem)
    {
        this.healthSystem = healthSystem;
    }


    private void Update()
    {
        sliderHealth.value = healthSystem.GetHealth();
    }
}
