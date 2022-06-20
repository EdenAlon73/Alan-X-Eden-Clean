using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class ScorePulseDotween : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private int scoreValue = 0;
    [SerializeField][Range(0, 1.5f)] private float tweenDuration;
    [SerializeField][Range(0, 1.5f)] private float tweenStrength;
    [SerializeField][Range(0, 10)] private int tweenVibrato;
    [SerializeField][Range(0, 90)] private float tweenRandomness;

    
    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreValue = 0;
        
    }

    private void Update()
    {
        scoreText.text = scoreValue.ToString();
        ChangeScore();
    }

    private void ChangeScore()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scoreValue += 10;
            scoreText.transform.DOShakeScale(tweenDuration, tweenStrength, tweenVibrato, tweenRandomness, true);
            scoreText.transform.DOShakePosition(tweenDuration, tweenStrength, tweenVibrato, tweenRandomness, true, true);
        }
    }
}
