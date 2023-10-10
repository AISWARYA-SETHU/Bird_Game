//This script can also be modified to use the Singleton Design pattern for working

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    //public static Controller Instance { get; private set; }

    private int _score = 0;

    /*void Awake()
    {
        if ((Instance != null) && (Instance != this))
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }*/

    /*public void AddScore(int points)
    {
        _score += points;
        scoreText.text = _score.ToString();
    }*/

    public void OnPlayAgainClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /*public void OnGameOver()
    {
        gameOver.SetActive(true);
    }*/
}
