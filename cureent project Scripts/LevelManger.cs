using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManger : MonoBehaviour
{
   public void LoadLevel(int levelIndex)
   {
      UnityEngine.SceneManagement.SceneManager.LoadScene(levelIndex);
      
      //AdManager.instance.ShowInterstitial();
   }
}
