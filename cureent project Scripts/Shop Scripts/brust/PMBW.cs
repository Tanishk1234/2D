using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMBW : MonoBehaviour
{
  public GameObject[] PlayerPrefabs;
  int BW;
  void Awake()
  {
    BW = PlayerPrefs.GetInt("SCBW" , 0);
    GameObject player = Instantiate(PlayerPrefabs[BW] ,transform.position , Quaternion.identity);
  }
  
}
