using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CoinTruck : MonoBehaviour
{
     public static int numberOfCoins;
     public TextMeshProUGUI CoinsText;

     void Awake()
     {
        PlayerPrefs.DeleteKey("NumberOfCoins");
        numberOfCoins = PlayerPrefs.GetInt("NumberOfCoins" , 0);
     }
    public void Update()
     {
       CoinsText.text = numberOfCoins.ToString();
     }
}
