using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(1, 0, 0) * speed * Time.fixedDeltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.CompareTag ("Boundary"))
       {
            Destroy(gameObject);
       }
    }
}