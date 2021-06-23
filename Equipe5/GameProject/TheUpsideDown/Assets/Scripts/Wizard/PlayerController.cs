using Assets.Enums;
using Assets.Utils.Extensions;
using UnityEngine;
using System;

namespace ClearSky
{
    public class PlayerController : MonoBehaviour
    {
        public const float MOVE_POWER = 10f;
        // Set Gravity Scale in Rigidbody2D Component to 5
        public const float JUMP_POWER = 15f;

        private const int LEFT = -1;
        private const int RIGHT = 1;

        private Rigidbody2D RigidBody;
        private Animator Animation;
        private int Direction = RIGHT;
        bool IsJumping = false;
        private bool Alive = true;

        private void Start()
        {
            RigidBody = GetComponent<Rigidbody2D>();
            Animation = GetComponent<Animator>();
        }

        private void Update()
        {
            Restart();

            if (Alive)
            {
                Hurt();
                Die();
                Attack();
                Jump();
                Run();
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
            if (Input.GetKeyDown(KeyCode.E))
            {
                Animation.SetTrigger(WizardStates.Attack.GetStringValue());
            }
        }

        private void Hurt()
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Animation.SetTrigger(WizardStates.Hurt.GetStringValue());

                var aux = Direction == RIGHT ? -1 : 1;
                RigidBody.AddForce(new Vector2(5f * aux, 1f), ForceMode2D.Impulse);
            }
        }

        private void Die()
        {
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Animation.SetTrigger(WizardStates.Die.GetStringValue());
                Alive = false;
            }
        }

        private void Restart()
        {
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                Animation.SetTrigger(WizardStates.Idle.GetStringValue());
                Alive = true;
            }
        }
    }
}