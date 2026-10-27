using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    private float move;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocityX =  move * speed * Time.fixedDeltaTime;

        //rb.MovePosition(transform.position + Vector3.right * Time.fixedDeltaTime); <- does the same thing as line 13
    }
    public void OnMovement (InputValue input)
    {
        move = input.Get<float>();
    }
}