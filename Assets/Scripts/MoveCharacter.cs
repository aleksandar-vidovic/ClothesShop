using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;

    private float directionX;
    private float directionY;

    private void Update()
    {
        MovingInput();
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
