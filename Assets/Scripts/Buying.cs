using UnityEngine;

public class Buying : MonoBehaviour
{
    [SerializeField] private GameObject interactWithSeller;
    [SerializeField] private GameObject buyClothes;
    [SerializeField] private GameObject sellClothes;
    [SerializeField] private GameObject wearClothes;
    [SerializeField] private CamZoomInOut camZoomInOut;

    private void Update()
    {
        if (!BuySellWear.uiActive && Input.GetButtonDown("Jump"))
        {
            BuySellWear.uiActive = true;
            wearClothes.SetActive(true);
            camZoomInOut.ZoomIn();
        }
    }

    public void BuyButton()
    {
        interactWithSeller.SetActive(false);
        buyClothes.SetActive(true);
    }

    public void SellButton()
    {
        interactWithSeller.SetActive(false);
        sellClothes.SetActive(true);
    }

    public void CloseSeller()
    {
        interactWithSeller.SetActive(false);
        BuySellWear.uiActive = false;
        camZoomInOut.ZoomOut();
    }

    public void CloseBuying()
    {
        buyClothes.SetActive(false);
        BuySellWear.uiActive = false;
        camZoomInOut.ZoomOut();
    }

    public void CloseSelling()
    {
        sellClothes.SetActive(false);
        BuySellWear.uiActive = false;
        camZoomInOut.ZoomOut();
    }

    public void CloseOutfit()
    {
        wearClothes.SetActive(false);
        BuySellWear.uiActive = false;
        camZoomInOut.ZoomOut();
    }
}
