using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents Current;

    private void Awake()
    {
        if (Current == null)
        {
            Current = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public event Action<int> onDealDamage;

    public void DealDamage(int num)
    {

        if (onDealDamage != null) onDealDamage(num);
    }


}





    















