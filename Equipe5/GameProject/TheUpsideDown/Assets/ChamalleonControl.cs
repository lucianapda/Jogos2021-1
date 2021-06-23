using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChamalleonControl : MonoBehaviour
{
    private float timeInterval = 0.4f;
    private float timer = 0;
    private Rigidbody2D rb2D;
    private GameObject chamalleonObject;
    private float chamalleonWalk = 1.0f;
    private Animator Animation;

    void Start()
    {
      chamalleonObject = GameObject.Find("Chamalleon");
      rb2D = chamalleonObject.GetComponent<Rigidbody2D>();
      Animation = GetComponent<Animator>();
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
      chamalleonObject.transform.position -= new Vector3(chamalleonWalk,0,0);
    }

     private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.CompareTag("left_wall") || collision.gameObject.CompareTag("right_wall") || collision.gameObject.CompareTag("wizard"))
      {
        chamalleonObject.transform.Rotate(new Vector3(0, 180, 0));
        chamalleonWalk *= -1;
      }
    }

}
