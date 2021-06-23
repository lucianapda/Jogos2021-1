using Assets.Enums;
using Assets.Utils.Extensions;
using UnityEngine;

namespace ClearSky
{
    public class PlayerController : MonoBehaviour
    {
        public const float MOVE_POWER = 10f;
        public const float JUMP_POWER = 15f;

        private const int LEFT = -1;
        private const int RIGHT = 1;

        private Rigidbody2D RigidBody;
        private Animator Animation;
        public HealthBar HealthBar;

        private int Direction = RIGHT;
        bool IsJumping = false;

        public float MaxHealth = 100;
        public float CurrentHealth;

        private bool Alive => CurrentHealth > 0;
        private bool _dead = false;

        private void Start()
        {
            RigidBody = GetComponent<Rigidbody2D>();
            Animation = GetComponent<Animator>();
            HealthBar.SetMaxHealth(MaxHealth);
            CurrentHealth = MaxHealth;
            HealthBar.SetHeath(CurrentHealth);

            Restart();
        }

        private void Update()
        {
            if (Alive)
            {
                if (Input.GetMouseButtonDown(Constants.PRIMARY_BUTTON))
                {
                    Attack();
                }
                Jump();
                Run();
            }
            else
            {
                Die();
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Animation.SetBool(WizardStates.IsJump.GetStringValue(), false);
        }

        private void Run()
        {
            Vector3 moveVelocity = Vector3.zero;
            Animation.SetBool(WizardStates.IsRun.GetStringValue(), false);
            var horizontalAxis = Input.GetAxisRaw("Horizontal");

            if (horizontalAxis != 0)
            {
                if (horizontalAxis < 0)
                {
                    Direction = LEFT;
                    moveVelocity = Vector3.left;
                }
                else if (horizontalAxis > 0)
                {
                    Direction = RIGHT;
                    moveVelocity = Vector3.right;
                }

                transform.localScale = new Vector3(Direction, 1, 1);

                if (!Animation.GetBool(WizardStates.IsJump.GetStringValue()))
                    Animation.SetBool(WizardStates.IsRun.GetStringValue(), true);
            }

            transform.position += moveVelocity * MOVE_POWER * Time.deltaTime;
        }

        private void Jump()
        {
            if ((Input.GetButtonDown("Jump") || Input.GetAxisRaw("Vertical") > 0) && !Animation.GetBool(WizardStates.IsJump.GetStringValue()))
            {
                IsJumping = true;
                Animation.SetBool(WizardStates.IsJump.GetStringValue(), true);
            }
            if (!IsJumping)
            {
                return;
            }

            RigidBody.velocity = Vector2.zero;

            Vector2 jumpVelocity = new Vector2(0, JUMP_POWER);
            RigidBody.AddForce(jumpVelocity, ForceMode2D.Impulse);

            IsJumping = false;
        }

        private void Attack()
        {
            Animation.SetTrigger(WizardStates.Attack.GetStringValue());
        }

        public void Hurt(float damage = 10)
        {
            Animation.SetTrigger(WizardStates.Hurt.GetStringValue());

            var aux = Direction == RIGHT ? -1 : 1;
            RigidBody.AddForce(new Vector2(5f * aux, 1f), ForceMode2D.Impulse);
            TakeDamage(damage);
        }

        private void Die()
        {
            if (!_dead)
            {
                Animation.SetTrigger(WizardStates.Die.GetStringValue());
                _dead = true;
            }
        }

        public void Restart()
        {
            Direction = RIGHT;
            IsJumping = false;
            _dead = false;
            CurrentHealth = MaxHealth;
            HealthBar.SetHeath(CurrentHealth);
            Animation.SetTrigger(WizardStates.Idle.GetStringValue());
        }

        public void TakeDamage(float damage)
        {
            CurrentHealth -= damage;
            HealthBar.SetHeath(CurrentHealth);
        }
    }
}