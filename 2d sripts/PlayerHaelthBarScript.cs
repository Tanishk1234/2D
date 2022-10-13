using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHaelthBarScript : MonoBehaviour
{
   public Image bar;
    
    public void SetAmount(float amount)
    {
        bar.fillAmount = amount;
    }
}
