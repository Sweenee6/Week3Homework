using UnityEngine;

public class GameManager : MonoBehaviour
{
    public const float ROW_HEIGHT = 0.48f;
    public const int PIECE_COUNT_PER_ROW = 13;
    public const float PIECE_LENGTH = 0.96f;
    public const int TOTAL_ROWS = 10;

    [SerializeField]
    private Transform pieces = null;

    [SerializeField]
    private GameObject piecePrefab = null;

    [SerializeField]
    private EdgeCollider2D border;

    [SerializeField]
    private GameObject ballLauncher = null;
    [SerializeField]
    private GameObject ball = null;

    //TODO
    //Using const data defined above "Instantiate" new pieces to fill the view with

    private void Start()
    {
        for (int y=0; y<TOTAL_ROWS; ++y)
        {
            for (int x = 0; x < PIECE_COUNT_PER_ROW; ++x)
            {
                Instantiate(piecePrefab, new Vector3(pieces.position.x + (x * PIECE_LENGTH), pieces.position.y - (y * ROW_HEIGHT), 0.0f), Quaternion.identity);
            }
        }
    }

    private void Update()
    {
        //Launch the ball from the launched with space
        if (Input.GetKeyDown(KeyCode.Space) && ballLauncher.GetComponent<SpriteRenderer>().enabled == true)
        {
            // spawn ball at Lancher position
            Instantiate(ball, new Vector3(ballLauncher.transform.position.x, ballLauncher.transform.position.y + 0.5f, 0f), Quaternion.identity);

            // Hide the launcher sprite
            ballLauncher.GetComponent<SpriteRenderer>().enabled = false;
        }
    }// end update

}
