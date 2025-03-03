using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Generate a random direction
        float randomDirectionX = Random.Range(-1f, 1f);
        float randomDirectionY = Random.Range(-1f, 1f);
        Vector2 randomDirection = new Vector2(randomDirectionX, randomDirectionY).normalized;

        // Set the ball's velocity
        GetComponent<Rigidbody2D>().linearVelocity = randomDirection * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Called when the ball collides with another object
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with a wall
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Reflect the ball's velocity based on the collision normal
            Vector2 reflectDirection = Vector2.Reflect(GetComponent<Rigidbody2D>().linearVelocity, collision.contacts[0].normal);
            GetComponent<Rigidbody2D>().linearVelocity = reflectDirection.normalized * speed;
        }
    }
}
