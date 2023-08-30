using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1 : MonoBehaviour
{
 public GameObject CoinPrefs;
 private void OnMouseDown() 
    {
        Destroy(gameObject);
        Debug.Log("Balls Destroyed");
        Instantiate(CoinPrefs , transform.position , Quaternion.identity);
    }
}
