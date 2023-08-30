using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMB : MonoBehaviour
{
  public GameObject[] PlayerPrefabs;
  [SerializeField] float secondSpawn = 0.5f;
    
  [SerializeField] float minTras;
    
  [SerializeField] float maxTras;
  private bool lastSpawn = false;
  public GM1 gM1;
  public int BallsSpawnCount;
  int B;
  void Awake()
  {
    PlayerPrefs.DeleteKey("SCB");
    B = PlayerPrefs.GetInt("SCB" , 0);
    GameObject player = Instantiate(PlayerPrefabs[B] ,transform.position , Quaternion.identity);
  }
      // Name Exchange Left With BS
  private void Start()
  {
      StartCoroutine(BallSpawn());
  }
  void Update()
  {
      if (lastSpawn&&FindObjectOfType<P1>()==null)
      {
          gM1.WinMenu.SetActive(true);
          Time.timeScale = 0f;
      }
  }
      // Name Exchange Left With BS

    IEnumerator BallSpawn()
    {
        for (int i = 0; i < BallsSpawnCount; i++)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector2(wanted, transform.position.y);
            GameObject gameObject = Instantiate(PlayerPrefabs[B] , transform.position , Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
        }
        lastSpawn = true;
            // Name Exchange Left With BS

    }
}
