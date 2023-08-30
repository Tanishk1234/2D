using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LCEB : MonoBehaviour
{
    public int Level = 0;
    public List<Button> LevelButtons = new List<Button>();
    
    private void Start()
    {
        PlayerPrefs.DeleteKey("LevelsCleared");
        if (PlayerPrefs.HasKey("LevelsCleared"))
        {
            UpdateLevel(PlayerPrefs.GetInt("LevelsCleared"));
        }
        else
        {
            UpdateLevel(Level);
            PlayerPrefs.SetInt("LevelsCleared", Level);
        }
    }

    public void UpdateLevel(int Levelnum)
    {
        for (int i = 0; i < LevelButtons.Count; i++)
        {
            if (i <= Levelnum)
            {
                LevelButtons[i].interactable = true;
            }
            else
            {
                LevelButtons[i].interactable = false;
            }
        }
    }
    public void LevelCleared(int nextLevelnum)
    {
       int lvlClear = PlayerPrefs.GetInt("LevelsCleared");
        if (lvlClear <= nextLevelnum)
        {
            PlayerPrefs.SetInt("LevelsCleared", nextLevelnum);
            lvlClear = nextLevelnum;
        }
       UpdateLevel(lvlClear);
    }    
   public void LoadLevel(int levelIndex)
   {
      UnityEngine.SceneManagement.SceneManager.LoadScene(levelIndex);
      
      //AdManager.instance.ShowInterstitial();
   }
   public void Next()
   {
     int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
   }
      public void Previous()
   {
     int nextLevel = SceneManager.GetActiveScene().buildIndex - 1;
   }
}
