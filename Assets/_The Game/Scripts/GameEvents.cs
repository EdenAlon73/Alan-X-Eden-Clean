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

    public event Action<int> onDealHealth;

    public void DealHealth(int num)
    {

        onDealHealth?.Invoke(num);
    }

    public event Action OnUpdateHealth;
    public void UpdateHealth()
    {
        OnUpdateHealth?.Invoke();
    }


}





    















