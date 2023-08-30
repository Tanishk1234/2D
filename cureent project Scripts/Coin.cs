using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D collision)
   {
      PlayerPrefs.DeleteAll();
     if(collision.transform.tag == "CoinTruck")
     {
        CoinTruck.numberOfCoins++;
        PlayerPrefs.SetInt("NumberOfCoins" , CoinTruck.numberOfCoins);
        Destroy(gameObject);
     }
   }
}
