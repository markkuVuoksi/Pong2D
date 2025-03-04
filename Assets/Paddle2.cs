using UnityEngine;

public class Paddle2 : MonoBehaviour
{
    public float speed = 5f; // Speed of the paddle
    public float boundaryY = 4.5f; // Adjust this value based on your game view boundaries

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePaddle();
    }

    // Move the paddle based on player input
    void MovePaddle()
    {
        float move = 0f;

        // Check for up and down arrow key input
        if (Input.GetKey(KeyCode.UpArrow))
        {
            move = speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            move = -speed * Time.deltaTime;
        }

        // Calculate new position
        float newY = transform.position.y + move;

        // Clamp the new position within the boundaries
        newY = Mathf.Clamp(newY, -boundaryY, boundaryY);

        // Move the paddle
        transform.position = new Vector2(transform.position.x, newY);
    }
}
