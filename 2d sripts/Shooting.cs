using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// where bullet want to shoot
public class Shooting : MonoBehaviour
{   
    public GameObject Flash;
    public GameObject playerBullet;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public float bulletSpawnTime = 0.25f;

    void Start()
    {
        StartCoroutine(Shoot());
        Flash.SetActive(false);
    }

    void Update()
    {
       
    }

      void Fire()
        {
             Instantiate(playerBullet,spawnPoint1.position,Quaternion.identity);
             Instantiate(playerBullet,spawnPoint2.position,Quaternion.identity);
        }

        IEnumerator Shoot()
        {
            while (true)
         {
                yield return new WaitForSeconds (bulletSpawnTime);
                Fire();
                Flash.SetActive(true);
                yield return new WaitForSeconds (0.04f);
                Flash.SetActive(false);
         }
          

        }
}
