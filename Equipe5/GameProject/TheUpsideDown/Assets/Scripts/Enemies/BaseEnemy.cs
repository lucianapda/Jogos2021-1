using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{
    protected abstract string TagName { get; }

    protected virtual float TimeInterval { get; } = .4f;

    protected virtual float WalkDistance { get; private set; } = 1.0f;
    protected virtual float MovePower { get; } = 1f;

    private float _timer = 0;

    void Update()
    {
        Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var collidedObject = collision.gameObject;
        Debug.Log(collidedObject.tag);

        if (collidedObject.CompareTag("wall"))
            Rotate();
        else if (collidedObject.CompareTag("wizard"))
        {
            // Attack
        }
    }

    public void Move()
    {
        _timer += Time.deltaTime;

        if (_timer > TimeInterval)
        {
            GameObject.Find(TagName).transform.position -= new Vector3(WalkDistance, 0, 0);
            _timer = 0;
        }
    }

    public void Rotate()
    {
        gameObject.transform.Rotate(new Vector3(0, 180, 0));
        WalkDistance *= -1 * MovePower;
    }
}
