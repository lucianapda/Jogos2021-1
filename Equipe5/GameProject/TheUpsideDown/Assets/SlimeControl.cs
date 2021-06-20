using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SlimeControl : MonoBehaviour
{
    private float timeInterval = 0.4f;
    private float timer = 0;
    private Rigidbody2D rb2D;
    private GameObject slimeObject;
    private int slimeWalk = -100;

    void Start()
    {
      slimeObject = GameObject.Find("Slime");
      rb2D = slimeObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
      timer += Time.deltaTime;

      if (timer > timeInterval) {
        Move();
        timer = 0;
      }
    }

    void Move()
    {
      rb2D.AddForce(new Vector2(slimeWalk, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.CompareTag("left_wall") || collision.gameObject.CompareTag("right_wall"))
      {
        slimeObject.transform.Rotate(new Vector3(0, 180, 0));
        slimeWalk *= -1;
      } 
    }

}
