using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectaParede : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

      Debug.Log(collision.gameObject.tag);
      
      if (collision.gameObject.CompareTag("ground"))
        {
            Debug.Log(collision);
        }
      
    }
}
