using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdGame : MonoBehaviour
{
    public delegate void BirdStatus();
    public static event BirdStatus OnBirdKilled;

    private Rigidbody2D _rigidBody;
    private int _movementSpeed = 20;
    private bool _birdAlive;

    void Start()
    {
        _birdAlive = true;
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _birdAlive)
        {
            _rigidBody.velocity = Vector2.up * _movementSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _birdAlive = false;
        //Controller.Instance.OnGameOver();

        OnBirdKilled?.Invoke();
    }
}
