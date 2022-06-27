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
    private ScorePulseDotween scorePulseDotween;

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
        scorePulseDotween = FindObjectOfType<ScorePulseDotween>();
    }

    public event Action onHeal;
    public void Heal()
    {

        onHeal?.Invoke();
    }

    public event Action onScoreChange;

    public void ScoreChange()
    {
        onScoreChange?.Invoke();
    }

    public event Action onPlayerDead;

    public void PlayerDead()
    {
        onPlayerDead?.Invoke();
    }



}





    















