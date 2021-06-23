using ClearSky;
using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{
    protected abstract string TagName { get; }

    protected virtual float TimeInterval { get; } = .4f;

    protected virtual float WalkDistance { get; private set; } = 1.0f;
    protected virtual float MovePower { get; } = 1f;
    protected virtual float DamagePower { get; } = 10f;

    protected virtual float MaxHealth { get; } = 25f;

    private float _currentHealth;
    private bool Alive => _currentHealth > 0;

    private float _timer = 0;

    public PlayerController Player;

    void Start()
    {
        _currentHealth = MaxHealth;
    }

    void Update()
    {
        if (Alive)
            Move();
        else
            gameObject.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        var collidedObject = collision.gameObject;

        if (collidedObject.CompareTag("wall"))
            Rotate();
        else if (collidedObject.CompareTag("wizard"))
            Player.Hurt(DamagePower);
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

    public void Hurt(float damage)
    {
        _currentHealth -= damage;
    }

    public void Rotate()
    {
        gameObject.transform.Rotate(new Vector3(0, 180, 0));
        WalkDistance *= -1 * MovePower;
    }
}
