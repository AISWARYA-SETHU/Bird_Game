using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIUpdations : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameOver;

    private int _score;

    void Start()
    {
        _score = 0;
    }

    
    void Update()
    {
        
    }

    private void AddScore(int score)
    {
        _score += score;
        scoreText.text = _score.ToString();
    }

    private void GameOver()
    {
        gameOver.SetActive(true);
    }

    private void OnEnable()
    {
        MiddlePipe.OnScoreUpdated += AddScore;
        BirdGame.OnBirdKilled += GameOver;
    }

    private void OnDisable()
    {
        MiddlePipe.OnScoreUpdated -= AddScore;
        BirdGame.OnBirdKilled -= GameOver;
    }
}
