using UnityEngine;

public class PieceColor : MonoBehaviour
{
    /*[SerializeField]
    private Sprite blueColor;
    [SerializeField]
    private Sprite redColor;
    [SerializeField]
    private Sprite greenColor;
    [SerializeField]
    private Sprite purpleColor;
    [SerializeField]
    private Sprite goldColor;
    [SerializeField]
    private Sprite greyColor;
    [SerializeField]
    private Sprite brownColor;
    */

    [SerializeField]
    private Sprite[] Colors = null;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        ChooseColor();
    }

    private void ChooseColor()
    {
        //TODO
        // set spriteRenderer.sprite to a random sprite that is present above

        int randomColor = Random.Range(0, 6);
        spriteRenderer.sprite = Colors[randomColor];
    }
}
