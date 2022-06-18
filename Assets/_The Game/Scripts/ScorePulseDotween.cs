using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Core;
using TMPro;
using UnityEngine;

public class ScorePulseDotween : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int scoreValue = 0;

    
    private void Awake()
    {
        scoreValue = 0;
        
    }

    private void Update()
    {
        scoreText.text = scoreValue.ToString();
    }

    private void ChangeScore()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
        }
    }
}
