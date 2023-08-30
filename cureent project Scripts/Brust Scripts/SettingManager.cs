using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingManager : MonoBehaviour
{

  public GameObject AudioSource;
  public GameObject RainPlayer;
  public Image RainOn;
  public Image RainOff;
  public Image AudioSourceOn;
  public Image AudioSourceOff;
  //int OtherIndex;
  int AudioSourceIndex;
  int RainIndex;
void Update()
  {
      if(RainIndex == 1)
      {
        RainPlayer.SetActive(false);
      } 
      if(RainIndex == 0)
      {
        RainPlayer.SetActive(true);
      } 
      if(AudioSourceIndex == 1)
      {
        AudioSource.SetActive(false);
      } 
      if(AudioSourceIndex == 0)
      {
        AudioSource.SetActive(true);
      }
  
  }
public void RainON() 
{
   RainIndex = 1;
   RainOff.gameObject.SetActive(true);
   RainOn.gameObject.SetActive(false);
}
public void RainOFF()
{
    RainIndex = 0;
    RainOff.gameObject.SetActive(false);
    RainOn.gameObject.SetActive(true);
}
public void AudioSourceON() 
{
   AudioSourceIndex = 1;
   AudioSourceOff.gameObject.SetActive(true);
   AudioSourceOn.gameObject.SetActive(false);
}
public void   AudioSourceOFF()
{
   AudioSourceIndex = 0;
   AudioSourceOff.gameObject.SetActive(false);
   AudioSourceOn.gameObject.SetActive(true);
}    
}
