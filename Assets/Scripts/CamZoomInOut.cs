using UnityEngine;

public class CamZoomInOut : MonoBehaviour
{
    [SerializeField] private Camera mainCam;
    [SerializeField] private float camOrthographicSizeZoomIn;
    [SerializeField] private Transform character;
    [SerializeField] private float camOffsetY;
    [SerializeField] private float camOrthographicSizeZoomOut;
    [SerializeField] private Rigidbody2D characterRb;

    public void ZoomIn()
    {
        characterRb.constraints = RigidbodyConstraints2D.FreezeAll;
        mainCam.orthographicSize = camOrthographicSizeZoomIn;
        transform.position = new Vector3(character.position.x, character.position.y + camOffsetY, -10);
    }

    public void ZoomOut()
    {
        mainCam.orthographicSize = camOrthographicSizeZoomOut;
        transform.position = new Vector3(0, 0, -10);
        characterRb.constraints = RigidbodyConstraints2D.None;
        characterRb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}
