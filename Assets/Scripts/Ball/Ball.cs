using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidBody = null;
    [SerializeField]
    private float speed = 1.0f;

    private Vector3 currentDirection = Vector3.zero;

    private void Awake()
    {
        currentDirection = new Vector3(Random(), 1.0f, 0).normalized;
    }

    private void FixedUpdate()
    {
        var newDelta = currentDirection * Time.deltaTime * speed;
        rigidBody.MovePosition(transform.position + newDelta);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentDirection = Vector2.Reflect(currentDirection, collision.contacts[0].normal);

        // if collides with piece, destroy the piece
        if (collision.gameObject.tag == "Piece")
        {
            Destroy(collision.gameObject);
        };
    }



    private int Random()
    {
        return UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
    }

    //TODO: Add code to move ball along with code to delete pieces upon colliding with one
    //Ball should only move once its been launched




}
