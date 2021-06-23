using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SlimeControl : BaseEnemies
{
    void Start()
    {
      Object = GameObject.Find("Slime");
      Rb2D = Object.GetComponent<Rigidbody2D>();
      TagName = "Slime";
    }

    void Update()
    {
      Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.CompareTag("left_wall") || collision.gameObject.CompareTag("right_wall") || collision.gameObject.CompareTag("wizard"))
      {
        Rotate();
      }
    }
}
