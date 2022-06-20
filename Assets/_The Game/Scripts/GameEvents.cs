using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents Current;

    //Cache Ref
    private RealHealthSystem realHealthSystem;
    private PlayerController playerController;

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
        
        realHealthSystem = FindObjectOfType<RealHealthSystem>();
        playerController = FindObjectOfType<PlayerController>();
    }

    public event Action onHeal;
    public void Heal()
    {

        onHeal?.Invoke();
    }



}





    















