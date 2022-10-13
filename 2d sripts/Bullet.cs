using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// shooting for all game
public class Bullet : MonoBehaviour
{
    public float speed;

  void Update()
  {
      transform.Translate(Vector2.up * speed * Time.deltaTime);
  }
}
