using TMPro;
using UnityEngine;

public class InteractWithSeller : MonoBehaviour
{
    [SerializeField] private TMP_Text txtMoveInteract;
    [SerializeField] private GameObject interactWithSeller;
    [SerializeField] private CamZoomInOut camZoomInOut;

    private bool firstTimeInteracted;
    private bool frontOfSeller;

    private void Update()
    {
        if (frontOfSeller && !BuySellWear.uiActive && Input.GetButtonDown("Submit"))
        {
            if (!firstTimeInteracted)
            {
                txtMoveInteract.text = "";
                firstTimeInteracted = true;
            }

            BuySellWear.uiActive = true;
            interactWithSeller.SetActive(true);
            camZoomInOut.ZoomIn();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Interact" && !frontOfSeller)
            frontOfSeller = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Interact" && frontOfSeller)
            frontOfSeller = false;
    }
}
