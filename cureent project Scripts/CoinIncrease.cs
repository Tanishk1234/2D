using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinIncrease : MonoBehaviour
{
    public int CoinAdds;
   public void CoinIncreaser()
   {
     int CurrentCoins = PlayerPrefs.GetInt("NumberOfCoins" , 0);
     int Quantity = CoinAdds;
     PlayerPrefs.SetInt("NumberOfCoins" , CurrentCoins + Quantity);
     Debug.Log("Coins Were Added");
   }
   public void TimeIncraeser()
   {
    
   }
}
