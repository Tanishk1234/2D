using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// for all game where healthBar needed
public class Healthbar : MonoBehaviour
{
    public Transform bar;

    void Start()
    {
        SetSize(0.25f);
    }
   
   public void SetSize (float size)
   {
       bar.localScale = new Vector2 (size , 1f);
   }

}


