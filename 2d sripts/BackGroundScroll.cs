using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// for all game
public class BackGroundScroll : MonoBehaviour
{
   public Renderer meshrenderer;
   public float speed;


   void Update()
   {
      
      Vector2 offset = meshrenderer.material.mainTextureOffset;
      offset = offset + new Vector2 (0, speed * Time.deltaTime);
      meshrenderer.material.mainTextureOffset = offset;

       meshrenderer.material.mainTextureOffset += new Vector2 (0, speed * Time.deltaTime);
      
   }
}
