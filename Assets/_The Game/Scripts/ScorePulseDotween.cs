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
    [SerializeField] private Vector3 tweenStrength;
    [SerializeField][Range(0, 10)] private int tweenVibrato;
    [SerializeField][Range(0, 90)] private float tweenRandomness;
    private float tweenElasticity;
    private int _counter=0;
    public Gradient gradient;
    public float alphaInt;

    
    private void Awake()
    {
        GameEvents.Current.onScoreChange += ChangeScore;


        scoreText = GetComponent<TextMeshProUGUI>();
        scoreValue = 0;
        tweenStrength = new Vector3(1, 1, 0);
        
    }


    private void OnDisable()
    {
        GameEvents.Current.onScoreChange -= ChangeScore;
    }

    private void Update()
    {
        scoreText.text = scoreValue.ToString();

      

        switch (scoreValue)
        {
            case 100:

                scoreText.color = new Color(0, 1, 0, 0.5f);

                break;

            case 200:

                scoreText.color = new Color(0, 1, 1, alphaInt);

                break;

            case 300:

                scoreText.color = new Color(0, 0, 1, alphaInt);

                break;

            case 400:

                scoreText.color = new Color(1, 0, 1, alphaInt);

                break;

            case 500:

                scoreText.color = new Color(1, 0.92f, 0.016f, alphaInt);

                break;


            case 600:

                scoreText.color = new Color(1, 0, 0, alphaInt);

                break;

        }
        
    }

    private void ChangeScore()
    {
      
            scoreValue += 10;
            scoreText.transform.DOPunchScale(tweenStrength,tweenDuration, tweenVibrato, tweenElasticity);
        
    }
}
