using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReloadScript : MonoBehaviour
{
   private int currentIndex;
   private void Start()
   {
      currentIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
   }

   public void pass()
   {
      int currentLevel = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
          
       if (currentLevel >= PlayerPrefs.GetInt("levelsUnlocked"))
      {
          PlayerPrefs.SetInt("levelsUnlocked" , currentLevel + 1);
      }
      
      Debug.Log("LEVEL" + PlayerPrefs.GetInt("levelsUnlocked")+ "Unlocked");
   }

   public  void PreviousLevel()
   {
      UnityEngine.SceneManagement.SceneManager.LoadScene(currentIndex-1);
      Time.timeScale = 1f;
   }
   
   
   public void Reload()
   {
      UnityEngine.SceneManagement.SceneManager.LoadScene(currentIndex);
      Time.timeScale = 1f;
   }
   public void QuitGame()
   {
      Application.Quit();
   }
}
