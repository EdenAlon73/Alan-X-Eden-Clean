using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents Current;

    public RealHealthSystem realHealthSystem;

    public PlayerController playerController;

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

    public event Action onHeal;
    public void Heal()
    {

        onHeal?.Invoke();
    }



}





    















