using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;

    //TODO
    // Move paddle left and right using keyboard keys, mapping is up to you
    private void Update()
    {
        //If A key is pressed move left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
        }

        //If D key is pressed move right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
        }

        //Clamp the paddle to the screen in 16:9
        var xPosition = Mathf.Clamp(transform.position.x, -5.31f, 5.31f);
        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);

    }//end of update

    // Paddle should be able to launch the ball upon space bar being pressed
    // A launched ball will then bounce around, changing its direction upon any collision
}
