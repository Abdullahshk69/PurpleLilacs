using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private Animator animator;
    public AudioSource audio;

    [SerializeField] private LayerMask jumpableGround;

    private float directionX;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;

    private float coyoteTimeCounter;
    [Tooltip("Time in which a player can still jump after leaving the ground")]
    [SerializeField] private float coyoteTime;

    [Tooltip("A player can jump before being on the ground for smoother feeling")]
    [SerializeField] private float jumpBuffer;
    private float jumpBufferCounter;
    [SerializeField] private float jumpTime;
    private float jumpTimeCounter;
    private bool isJumping;

    // Creating bool for jump, fall and such
    private enum MovementState { idle, running, jumping, falling }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        coll = GetComponent<BoxCollider2D>();
        jumpTimeCounter = jumpTime;
        isJumping = false;
    }

    private void Update()
    {
        GetXAxis();
        Move();
        CoyoteTime();
        JumpBuffer();
        TimeBuffer();

        // If you press the jump and you are on the ground or just left the ground
        // This works similar to GetButtonDown()
        if (jumpBufferCounter > 0f && coyoteTimeCounter > 0f)
        {
            // Jump
            audio.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpBufferCounter = 0f;
            isJumping = true;
        }

        // Keep holding down jump button
        if (Input.GetButtonUp("Jump") && (jumpTimeCounter > 0) && isJumping)
        {
            jumpTimeCounter -= Time.deltaTime;

            //Keep jumping
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * jumpTimeCounter);
            coyoteTimeCounter = 0f;
            isJumping = false;
        }
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        MovementState state;

        // Player is moving to the right
        if (directionX > 0f)
        {
            state = MovementState.running;
            transform.localScale = new Vector3(1, 1, 1);
        }

        // Player is moving to the left
        else if (directionX < 0f)
        {
            state = MovementState.running;
            transform.localScale = new Vector3(-1, 1, 1);
        }

        // Player is idle
        else
        {
            state = MovementState.idle;
        }

        // Player is jumping
        if (rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }

        // Player is falling
        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }
        animator.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
        float angle = 0f;
        float distance = 0.1f;
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, angle, Vector2.down, distance, jumpableGround);
    }

    private void GetXAxis()
    {
        // For better control on a controller
        directionX = Input.GetAxisRaw("Horizontal");
    }

    private void Move()
    {
        // One method can carry on both positive and negative movements
        // Making a player move along x axis while maintaining value on y axis
        rb.velocity = new Vector2(directionX * moveSpeed, rb.velocity.y);
    }

    private void CoyoteTime()
    {
        if (IsGrounded())
        {
            coyoteTimeCounter = coyoteTime;
        }
        else
        {
            coyoteTimeCounter -= Time.deltaTime;
        }
    }

    private void JumpBuffer()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jumpBufferCounter = jumpBuffer;
        }
        else
        {
            jumpBufferCounter -= Time.deltaTime;
        }
    }

    private void TimeBuffer()
    {
        if (IsGrounded())
        {
            jumpTimeCounter = jumpTime;
        }
        else
        {

        }
    }
}
