using UnityEngine;

public class Girl : MonoBehaviour
{
    // public float movePower = 10f;
    // public float jumpPower = 15f; //Set Gravity Scale in Rigidbody2D Component to 5
    private Rigidbody2D rb;
    private Animator anim;
    // Vector3 movement;
    // private int direction = 1;
    // bool isJumping = false;
    // private bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        Debug.Log(rb);
    }

    // Update is called once per frame
    void Update()
    {
        // Restart();
        // if (alive)
        // {
        //     Hurt();
        //     Die();
        //     Attack();
        //     Jump();
        //     Run();

        // }
    }

    void ResetAnimation()
    {
        anim.SetBool("isLookUp", false);
        anim.SetBool("isRun", false);
        anim.SetBool("isJump", false);
    }
    public void Idle()
    {
        ResetAnimation();
        anim.SetTrigger("idle");
    }
    public void Attack()
    {
        ResetAnimation();
        anim.SetTrigger("attack");
    }
    public void TripOver()
    {
        ResetAnimation();
        anim.SetTrigger("tripOver");
    }
    public void Hurt()
    {
        ResetAnimation();
        anim.SetTrigger("hurt");
    }
    public void Die()
    {
        ResetAnimation();
        anim.SetTrigger("die");
    }
    public void LookUp()
    {
        ResetAnimation();
        anim.SetBool("isLookUp", true);
    }
    public void Run()
    {
        ResetAnimation();
        anim.SetBool("isRun", true);

    }
    public void Jump()
    {
        ResetAnimation();
        anim.SetBool("isJump", true);

    }
}
