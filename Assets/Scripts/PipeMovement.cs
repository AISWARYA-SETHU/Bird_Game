using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    private int _movementSpeed;
    private int _deathPosition = -40;

    void Start()
    {
        _movementSpeed = 5;
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * _movementSpeed) * Time.deltaTime;

        //Inorder to destroy pipes as long as their visibility in screen ends
        if(transform.position.x < _deathPosition)
        {
            Destroy(gameObject);
        }
    }
}
