using System.Runtime.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//for spawning random enemy
public class Spawner : MonoBehaviour
{
    public GameObject[] enemy;
    public float minTime;
    public float maxTime;

    void Start()
    {
        InvokeRepeating ("SpawnEnemy" , Random.Range (minTime, maxTime), Random.Range (minTime, maxTime));
    }
    void SpawnEnemy()
    {
        Instantiate (enemy[Random.Range(0,enemy.Length)],transform.position , transform.rotation);
    }
}
