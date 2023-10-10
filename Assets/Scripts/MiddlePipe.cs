using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePipe : MonoBehaviour
{
    public delegate void UpdateScore(int score);
    public static UpdateScore OnScoreUpdated;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3) 
        {
            //Controller.Instance.AddScore(1);
            OnScoreUpdated?.Invoke(1);
        }
    }
}
