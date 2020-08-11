using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Public fields
    public float speed = 150f;
    public Vector2 maxVelocity = new Vector2(60, 100);
    public float jetSpeed = 200f;
    public bool standing;
    public float standingThreshold = 4f;
    public float airSpeedMultiplier = 0.3f;

    // Private Fields
    private Rigidbody2D body2D;
    private SpriteRenderer renderer2D;
    private PlayerController controller;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // Assign value to fields
        body2D = GetComponent<Rigidbody2D>();
        renderer2D = GetComponent<SpriteRenderer>();
        controller = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        // Absolute velocity X and Y for player regid body
        var absVelX = Mathf.Abs(body2D.velocity.x);
        var absVelY = Mathf.Abs(body2D.velocity.y);

        // Player is standing
        if(absVelY <= standingThreshold)
        {
            standing = true;
        }

        // Player isn't standing
        else
        {
            standing = false;
        }

        // Set X and Y force to 0f
        var forceX = 0f;
        var forceY = 0f;

        // If user presses A or D
        if (controller.moving.x != 0)
        {
            // If absolute velocity X less than the maximum
            if(absVelX < maxVelocity.x)
            {
                // Calculate speed that should be used
                var newSpeed = speed * controller.moving.x;

                // If standing is true force X multiply speed by 1 else multiply airSpeedMultiplier by 1
                forceX = standing ? newSpeed : (newSpeed * airSpeedMultiplier);

                // Player faces the way it moves
                renderer2D.flipX = forceX < 0;
            }

            // Show walk animation
            animator.SetInteger("AnimState", 1);
        }

        else
        {
            // Show idle animation
            animator.SetInteger("AnimState", 0);
        }

        // If user presses space bar
        if (controller.moving.y > 0)
        {
            // If absolute velocity Y less than the maximum
            if (absVelY < maxVelocity.y)
            {
                // Force Y multiply jetSpeed by 1
                forceY = jetSpeed * controller.moving.y;
            }

            // Show jet animation
            animator.SetInteger("AnimState", 2);
        }

        // If player is falling
        else if(absVelY > 0 && !standing)
        {
            // Show empty animation
            animator.SetInteger("AnimState", 3);
        }

        // Apply force to body
        body2D.AddForce(new Vector2(forceX, forceY));
    }
}
