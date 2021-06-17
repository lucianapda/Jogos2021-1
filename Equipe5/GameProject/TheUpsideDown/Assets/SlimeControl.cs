using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SlimeControl : MonoBehaviour
{
    // Start is called before the first frame update
    private float timeInterval;
    private float timer;
    private Rigidbody2D rb2D;
    private GameObject slimeObject;

    void Start()
    {
      slimeObject = GameObject.Find("Slime");
      rb2D = slimeObject.GetComponent<Rigidbody2D>();
      Debug.Log(rb2D);
      timeInterval = 0.5f;
      timer = 0;
    }

    // Update is called once per frame
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
      rb2D.AddForce(new Vector2(-100, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

      Debug.Log(collision);
      
      if (collision.gameObject.CompareTag("ground"))
        {
            Debug.Log(collision);
        }
      
    }

}
