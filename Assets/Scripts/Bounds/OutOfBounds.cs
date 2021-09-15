using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //TODO: Implement functionality to reset the game somehow.
        // Resetting the game includes destroying the out of bounds ball and creating a new one ready to be launched from the paddle

        // Look to see if collision is with the ball
        if (collision.CompareTag("Ball"))
        {
            // destroy the ball
            Destroy(collision.gameObject);
        }

    }
}
