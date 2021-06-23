using Assets.Enums;
using UnityEngine;

public class BaseEnemies : MonoBehaviour
{
    private float timeInterval = 0.4f;
    private float timer = 0;
    public Rigidbody2D Rb2D { get; set; }
    public GameObject Object { get; set; }
    public string TagName { get; set; }
    private float walk = 1.0f;
    public void Move()
    {
      timer += Time.deltaTime;

      if (timer > timeInterval) {
        GameObject.Find(TagName).transform.position -= new Vector3(walk,0,0);
        timer = 0;
      }
    }

    public void Rotate()
    {
      gameObject.transform.Rotate(new Vector3(0, 180, 0));
      walk *= -1;
    }
}
