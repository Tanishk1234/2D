using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneManager : MonoBehaviour
{
   private int levelsUnlocked;
  
   public Button[] button;

   private void Start()
   {
     // AdManager.instance.RequestInterstitial();
      levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked" , 1);
   
      for (int i = 0; i < button.Length; i++)
      
      {
         button[i].interactable = false;
      }

      for (int i = 0; i <levelsUnlocked; i++)
      {
         button[i].interactable = true;
      }
      
   }
   public void LoadLevel(int levelIndex)
   {
      UnityEngine.SceneManagement.SceneManager.LoadScene(levelIndex);
      
      //AdManager.instance.ShowInterstitial();
   }
}
