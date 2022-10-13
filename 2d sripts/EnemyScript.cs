using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// advance shooter game
public class EnemyScript : MonoBehaviour
{
    public Transform gunPoint1;
    public Transform gunPoint2;
    public GameObject enemyBullet;
    public float enemyBulletSpawnTime = 0.5f;
    public GameObject enemyFlash;
    public GameObject enemyExplosionPrefab;
    public GameObject DamageEffect;
    public Healthbar healthbar;
    public float speed = 1f;
    public float health = 10f;

    float barSize = 1f;
    float damage = 0;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player Bullet")
        {

            damageHealthbar ();
            Destroy(collision.gameObject);
           GameObject damageVfx = Instantiate(DamageEffect,collision.transform.position , Quaternion.identity);
           Destroy(damageVfx,0.1f);

            if (health <= 0 )
            {
                Destroy(gameObject);
                GameObject enemyExplosion =  Instantiate(enemyExplosionPrefab , transform.position,    Quaternion.identity);
                Destroy(enemyExplosion , 0.8F);
            }
         
        }
    }

     void Start()
     {
         StartCoroutine(EnemyShooting());
         enemyFlash.SetActive(false);
         damage = barSize / health;
     }


     void damageHealthbar ()
     {
         if (health > 0)
         {
             health -= 1;
             barSize = barSize - damage;
             healthbar.SetSize(barSize);
         }
     }


    void EnemyFire()
    {
        Instantiate(enemyBullet, gunPoint1.position, Quaternion.identity);
        Instantiate(enemyBullet, gunPoint2.position, Quaternion.identity);
    }

    IEnumerator EnemyShooting()
    {
        while (true)
        {
             yield return new WaitForSeconds(enemyBulletSpawnTime);
             EnemyFire();
              enemyFlash.SetActive(true);
                yield return new WaitForSeconds (0.04f);
              enemyFlash.SetActive(false);
        }
       
    }
}
