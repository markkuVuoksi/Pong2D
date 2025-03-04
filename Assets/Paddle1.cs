using UnityEngine;

public class Paddle1 : MonoBehaviour
{
    public float speed = 5f; // Speed of the paddle
    public GameObject ball; // Reference to the ball object
    public float randomness = 0.1f; // Randomness factor to make the computer miss sometimes

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePaddle();
    }

    // Move the paddle to follow the ball
    void MovePaddle()
    {
        if (ball != null)
        {
            // Get the ball's y-position
            float ballY = ball.transform.position.y;

            // Add some randomness to the paddle's movement
            float targetY = ballY + Random.Range(-randomness, randomness);

            // Move the paddle towards the target y-position
            Vector2 newPosition = new Vector2(transform.position.x, Mathf.Lerp(transform.position.y, targetY, speed * Time.deltaTime));
            transform.position = newPosition;
        }
    }
}
