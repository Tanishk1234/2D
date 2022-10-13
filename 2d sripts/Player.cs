using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Rase Up
public class Player : MonoBehaviour
{
  public Rigidbody2D rb;
  private float score;
  public Text scoreText;
  public Text finalScoreText;
  
  void Update()
  {
      Vector2 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
      rb.position = mousePos;
  }

     void FixedUpdate()
   {
       score++;
       scoreText.text = (score).ToString(); 
       finalScoreText.text = (score).ToString();     
   }


}
