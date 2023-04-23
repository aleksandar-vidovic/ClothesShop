using TMPro;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private TMP_Text txtMoveInteract;

    private float directionX;
    private float directionY;
    private bool moved;

    private void Update()
    {
        MovingInput();

        if (!moved && (directionX != 0 || directionY != 0))
        {
            txtMoveInteract.text = "Go to the SELLER and press ENTER to interact";
            moved = true;
        }
    }

    private void FixedUpdate()
    {
        Moving();
    }

    private void MovingInput()
    {
        directionX = Input.GetAxisRaw("Horizontal") * speed;
        directionY = Input.GetAxisRaw("Vertical") * speed;
    }

    private void Moving()
    {
        rb.velocity = new Vector2(directionX, directionY);
    }
}
