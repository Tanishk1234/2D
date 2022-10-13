using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// fighter plane
public class PlayerScript : MonoBehaviour
{
    public PlayerHaelthBarScript playerHaelthbar;
    public GameObject damageEffect;
    public GameObject explosion;
    public float padding = 0.8f;
    public float health = 20f;
    float barFillAmount = 1f;
    public float speed;
    float damage = 0;
    float MinX;
    float MaxX;
    float MinY;
    float MaxY;   
    
    

    void Start()
    {
         FinddBoundaries();
         damage = barFillAmount / health;
    }

    void FinddBoundaries()
    {
        Camera gameCamera = Camera.main;
        MinX = gameCamera.ViewportToWorldPoint(new Vector3(0,0,0)).x + padding;
        MaxX = gameCamera.ViewportToWorldPoint(new Vector3(1,0,0)).x - padding;
        MinY = gameCamera.ViewportToWorldPoint(new Vector3(0,0,0)).y + padding;
        MaxY = gameCamera.ViewportToWorldPoint(new Vector3(0,1,0)).y - padding;

    }

    void Update()
    {
         float deltaY =  Input.GetAxis("Vertical")  * speed * Time.deltaTime;
        float deltaX =  Input.GetAxis("Horizontal") * speed * Time.deltaTime;      
      
        float newYPos = Mathf.Clamp(transform.position.y + deltaY, MinY , MaxY);
        float newXPos = Mathf.Clamp(transform.position.x + deltaX, MinX , MaxX);
 
        transform.position = new Vector2 (newXPos, newYPos );   
    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if(Collision.gameObject.tag == "enymyBullet")
        {
            DamagePlayerHealthbar();
            Destroy(Collision.gameObject);
           GameObject damageVfx = Instantiate(damageEffect , Collision.transform.position , Quaternion.identity);
            Destroy(damageVfx,0.05f);
            if (health<=0)
            {
                Destroy(gameObject);
                GameObject blast = Instantiate(explosion,transform.position,Quaternion.identity);
                Destroy(blast,2f);
            }
          
        }
    }

    void DamagePlayerHealthbar()
    {
       if (health>0)
       {
           health -= 1;
           barFillAmount = barFillAmount - damage;
           playerHaelthbar.SetAmount(barFillAmount);
       }
    }
}
