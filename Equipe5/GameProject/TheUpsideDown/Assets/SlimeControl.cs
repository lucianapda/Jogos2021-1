using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SlimeControl : MonoBehaviour
{
    // Start is called before the first frame update
    private float TimeInterval;
    private float Timer;
    void Start()
    {
      TimeInterval = 0.5f;
      Timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
      float x = GameObject.Find("Slime").transform.position[0];

      Timer += Time.deltaTime;

      if (Timer > TimeInterval && x > 315) {
        Move();
        Timer = 0;
      }
    }

    void Move()
    {
      GameObject.Find("Slime").transform.position -= new Vector3(1.0f,0,0);
    }
}
