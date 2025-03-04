using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public float boundaryX = 9f; // Adjust this value based on your game view boundaries
    public float rotationSpeed = 200f; // Speed of the ball's rotation
    public GameManager gameManager; // Reference to the GameManager

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ResetBall();
    }

    // Update is called once per frame
    void Update()
    {
        CheckOutOfBounds();
        RotateBall();
    }

    // Check if the ball is out of bounds
    void CheckOutOfBounds()
    {
        if (Mathf.Abs(transform.position.x) > boundaryX)
        {
            if (transform.position.x > boundaryX)
            {
                gameManager.AddScorePaddle1();
            }
            else if (transform.position.x < -boundaryX)
            {
                gameManager.AddScorePaddle2();
            }
            ResetBall();
        }
    }

    // Rotate the ball
    void RotateBall()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    // Reset the ball to the origin with a new random direction
    void ResetBall()
    {
        transform.position = Vector2.zero;

        // Generate a random direction
        float randomDirectionX = Random.Range(-1f, 1f);
        float randomDirectionY = Random.Range(-1f, 1f);
        Vector2 randomDirection = new Vector2(randomDirectionX, randomDirectionY).normalized;

        // Set the ball's velocity
        GetComponent<Rigidbody2D>().linearVelocity = randomDirection * speed;
    }
}
