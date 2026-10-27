using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Vector2 move;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(move.x, move.y) * speed * Time.deltaTime;
    }
    public void OnMovement(InputValue input)
    {
        move = input.Get<Vector2>();
    }
}

