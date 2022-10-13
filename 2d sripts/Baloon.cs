using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloon : MonoBehaviour
{
     public GameController gameController;
     public AudioSource audioSource1;
     public AudioSource audioSource;
     private void OnCollisionEnter2D(Collision2D collision) 
      {

          void Start()
          {
              audioSource1.Play();
          }
          if (collision.gameObject.tag == "enemy")
          {    
               audioSource.Play();
               audioSource1.Pause();
               gameController.GameOver();
               Destroy(gameObject); 
          }
             
      }
}
