using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    private Vector2 move;
    public GameObject explosionEffect;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
            Instantiate(explosionEffect, transform.position, transform.rotation);
        }
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Start()
    {

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
