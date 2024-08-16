using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 move;
    [Range(1, 50)]
    public int speed = 1;
    private Rigidbody rigidbody;
    public float acceleration = 10;
    public float deceleration = 10;
    public float power = 0.96f;
    public Animator animator;

    void Start() // Start is called before the first frame update
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void FixedUpdate() // Update is called once per frame
    {
        Run();
    }

    public void onMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    private void Run()
    {
        Vector2 targetspeed = move * speed;
        Vector2 speedDiff = new Vector2(targetspeed.x - rigidbody.velocity.x,
                                        targetspeed.y - rigidbody.velocity.z);
        Vector2 accelRate = new Vector2((Mathf.Abs(targetspeed.x) > 0.01f) ? acceleration : deceleration,
                                        (Mathf.Abs(targetspeed.y) > 0.01f) ? acceleration : deceleration);
        Vector2 movement = new Vector2(Mathf.Pow(Mathf.Abs(speedDiff.x) * accelRate.x, power) * Mathf.Sign(speedDiff.x),
                                      Mathf.Pow(Mathf.Abs(speedDiff.y) * accelRate.y, power) * Mathf.Sign(speedDiff.y));
        rigidbody.AddForce(new Vector3 (movement.x, 0, movement.y));
        animator.SetFloat("speed_y", move.y);
        animator.SetFloat("speed_x", move.x);
    }
}