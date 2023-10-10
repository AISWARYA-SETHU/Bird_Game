using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject Pipes;

    private int _spawnTime = 3;
    private float _timer = 0;
    private int _heightOffset = 10;

    void Start()
    {
        StartSpawning();
    }

    void Update()
    {
        if(_timer < _spawnTime)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            StartSpawning();
            _timer = 0;
        }
    }

    void StartSpawning()
    {
        float minHeight = transform.position.y - _heightOffset;
        float maxHeight = transform.position.y + _heightOffset;
        Instantiate(Pipes, new Vector3(transform.position.x, Random.Range(minHeight, maxHeight), transform.position.z), transform.rotation);
    }
}
