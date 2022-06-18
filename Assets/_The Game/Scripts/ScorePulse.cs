using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScorePulse : MonoBehaviour
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
    
    

    private IEnumerator TextPulseCor()
    {
        for (float i = 1f; i <= 1f; i+= 0.05f)
        {
            scoreText.rectTransform.localScale = new Vector3(i, i, i);
            yield return new WaitForSeconds(0.01f);
        }
        scoreText.rectTransform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        scoreValue += 10;

        for (float i = 1.2f; i >= 1f; i-= 0.05f)
        {
            scoreText.rectTransform.localScale = new Vector3(i, i, i);
            yield return new WaitForSeconds(0.01f);
        }

        scoreText.rectTransform.localScale = new Vector3(1f, 1f, 1f);
    }

    public void RunPulseCor()
    {
        StartCoroutine(TextPulseCor());
    }
}
