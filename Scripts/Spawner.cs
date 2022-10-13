using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] BallsPrefab;
    
    [SerializeField] float secondSpawn = 0.5f;
    
    [SerializeField] float minTras;
    
    [SerializeField] float maxTras;
    
    public int BallsSpawnCount;
    private void Start()
    {
        StartCoroutine(BallSpawn());
    }

    IEnumerator BallSpawn()
    {
        for (int i = 0; i < BallsSpawnCount; i++)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector2(wanted, transform.position.y);
            GameObject gameObject = Instantiate(BallsPrefab[Random.Range(0, BallsPrefab.Length)], position,
                Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
        }
    }
}
