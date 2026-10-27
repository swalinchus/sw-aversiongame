using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private float jumpStatus;
    public float jumpPower;
    public float speed;
    private float move;
    private float movement;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (jumpStatus > float.Epsilon)
        {
            rb.AddForce(Vector2.up * jumpPower * Time.fixedDeltaTime, ForceMode2D.Force);
        }
        else
        {

        }

        rb.linearVelocityX =  move * speed * Time.fixedDeltaTime;

        //rb.MovePosition(transform.position + Vector3.right * Time.fixedDeltaTime); <- does the same thing as line 13
    }

    public void OnJetpack (InputValue input)
    {
       jumpStatus = input.Get<float>();
    }
    public void OnMove (InputValue input)
    {
        move = input.Get<float>();
    }
}