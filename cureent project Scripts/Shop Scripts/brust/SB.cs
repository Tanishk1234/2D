using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SB : MonoBehaviour
{
public GameObject[] Skins;
public CH[]ch0;
public Button UB0;
public TextMeshProUGUI ct0;
public int bs;
   private void Awake()
   {  
      PlayerPrefs.DeleteAll();
      bs = PlayerPrefs.GetInt("SCB", 0);
     
      foreach (GameObject player in Skins) 
         player.SetActive(false);
     Skins[bs].SetActive(true);

     foreach(CH c0 in ch0)
     {
       if(c0.CHP == 0)
         c0.CisUnlocked = true;
       else
       {
          c0.CisUnlocked = PlayerPrefs.GetInt(c0.CHN , 0) == 0 ? false : true;
       }
     }
     UpdateUI();
   }
   public void ChangeNext()
   {
    PlayerPrefs.DeleteAll();
     Skins[bs].SetActive(false);
     bs++;
     if(bs == Skins.Length)
           bs = 0;
           Skins[bs].SetActive(true);
           if(ch0[bs].CisUnlocked)
             PlayerPrefs.SetInt("SCB" , bs);
      UpdateUI();
   }
   public void ChangePrivious()
   {
    PlayerPrefs.DeleteAll();
     Skins[bs].SetActive(false);
     bs--;
     if(bs == -1)
           bs = Skins.Length -1;

           Skins[bs].SetActive(true);
            PlayerPrefs.SetInt("SCB" , bs);
          if(ch0[bs].CisUnlocked)
             PlayerPrefs.SetInt("SCB" , bs);
      UpdateUI();     
   }
  public void UpdateUI()
  {
    PlayerPrefs.DeleteAll();
    ct0 .text = "Coins:" + PlayerPrefs.GetInt("NumberOfCoins" , 0);
    if(ch0[bs].CisUnlocked == true)
       UB0.gameObject.SetActive(false);
    else
     {
       UB0.GetComponentInChildren<TextMeshProUGUI>().text = "Price:" + ch0[bs].CHP;
        if(PlayerPrefs.GetInt("NumberOfCoins" , 0) < ch0[bs].CHP)
        {
          UB0.gameObject.SetActive(true);
          UB0.interactable = false;          
        }
        else
       {
          UB0.gameObject.SetActive(true);
          UB0.interactable = true;        
       }
     }

  }
  public void Unlock()
  {
     PlayerPrefs.DeleteAll();
      int coin = PlayerPrefs.GetInt("NumberOfCoins" , 0);
      int price = ch0[bs].CHP;
      PlayerPrefs.SetInt("NumberOfCoins" , coin - price);
      PlayerPrefs.SetInt(ch0[bs].CHN , 1);
      PlayerPrefs.SetInt("SCB" , bs);
      ch0[bs].CisUnlocked = true;
      UpdateUI();
  }
}
