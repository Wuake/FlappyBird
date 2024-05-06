using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBehavior : MonoBehaviour
{
    public static ScoreBehavior instance;
    public TextMeshProUGUI currentScore;
    public TextMeshProUGUI bestScore;

    private int _score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        currentScore.text = _score.ToString();
        bestScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void UpdateScore()
    {
        _score++;
        currentScore.text = _score.ToString();
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            bestScore.text = _score.ToString();
        }
    }
}
