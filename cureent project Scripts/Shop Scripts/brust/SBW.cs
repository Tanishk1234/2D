using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
// Name Exchange Left With 
public class SBW : MonoBehaviour
{
   public GameObject[] Skins;
   public CH[]ch1;
   public Button UB1;      
   public TextMeshProUGUI ct1;       
   public int bsw;
   private void Awake()
   {
      bsw = PlayerPrefs.GetInt("SCBW", 0);
     
      foreach (GameObject player in Skins)
          player.SetActive(false);
     
     Skins[bsw].SetActive(true);
          foreach(CH c1 in ch1)
     {
       if(c1.CHP == 0)
         c1.CisUnlocked = true;
       else
       {
          c1.CisUnlocked = PlayerPrefs.GetInt(c1.CHN , 0) == 0 ? false : true;
       }
     }
     UpdateUI();
   }
   public void ChangeNext()
   {
     Skins[bsw].SetActive(false);
     bsw++;
     if(bsw == Skins.Length)
           bsw = 0;
           Skins[bsw].SetActive(true);
           if(ch1[bsw].CisUnlocked)
             PlayerPrefs.SetInt("SCBW" , bsw);
      UpdateUI();
   }
    // Name Exchange Left With BS
      public void ChangePrivious()
   {
     Skins[bsw].SetActive(false);
     bsw--;
     if(bsw == -1)
           bsw = Skins.Length -1;
           Skins[bsw].SetActive(true);
           if(ch1[bsw].CisUnlocked)
             PlayerPrefs.SetInt("SCBW" , bsw);
      UpdateUI();
   }
public void UpdateUI()
  {
    ct1 .text = "Coins:" + PlayerPrefs.GetInt("NumberOfCoins" , 0);
    if(ch1[bsw].CisUnlocked == true)
       UB1.gameObject.SetActive(false);
    else
     {
       UB1.GetComponentInChildren<TextMeshProUGUI>().text = "Price:" + ch1[bsw].CHP;
        if(PlayerPrefs.GetInt("NumberOfCoins" , 0) < ch1[bsw].CHP)
        {
          UB1.gameObject.SetActive(true);
          UB1.interactable = false;          
        }
        else
       {
          UB1.gameObject.SetActive(true);
          UB1.interactable = true;        
       }
     }

  }
  public void Unlock()
  {
      int coin = PlayerPrefs.GetInt("NumberOfCoins" , 0);
      int price = ch1[bsw].CHP;
      PlayerPrefs.SetInt("NumberOfCoins" , coin - price);
      PlayerPrefs.SetInt(ch1[bsw].CHN , 1);
      PlayerPrefs.SetInt("SCBW" , bsw);
      ch1[bsw].CisUnlocked = true;
      UpdateUI();
  }
}
