using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] BallsPrefab;
    
    [SerializeField] float secondSpawn = 0.5f;
    
    [SerializeField] float minTras;
    
    [SerializeField] float maxTras;
    private bool lastSpawn = false;
    public GM1 gM1;
    public int BallsSpawnCount;
    private void Start()
    {
        StartCoroutine(BallSpawn());
    }
void Update()
{
    if (lastSpawn&&FindObjectOfType<P1>()==null)
    {
        gM1.WinMenu.SetActive(true);
    }
}
    IEnumerator BallSpawn()
    {
        for (int i = 0; i < BallsSpawnCount; i++)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector2(wanted, transform.position.y);
            GameObject gameObject = Instantiate(BallsPrefab[Random.Range(0, BallsPrefab.Length)], position,Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
        }
        lastSpawn = true;
        
    }
}
