using System.Collections;
using TMPro;
using UnityEngine;

public class WearClothes : MonoBehaviour
{
    [SerializeField] private TMP_Text txtNoMoney;
    [SerializeField] private SpriteRenderer shirt;
    [SerializeField] private SpriteRenderer pants;
    [SerializeField] private SpriteRenderer shoes;

    public void ItemOne()
    {
        if (ClothesOne.owned)
        {
            Color shirtPantsColor;
            ColorUtility.TryParseHtmlString(ClothesOne.shirtPantsColor, out shirtPantsColor);
            Color shoesColor;
            ColorUtility.TryParseHtmlString(ClothesOne.shoesColor, out shoesColor);

            shirt.color = shirtPantsColor;
            pants.color = shirtPantsColor;
            shoes.color = shoesColor;
        }

        else
        {
            txtNoMoney.text = "You don't own that outfit.";
            StartCoroutine(DeleteText());
        }
    }

    public void ItemTwo()
    {
        if (ClothesTwo.owned)
        {
            Color shirtPantsColor;
            ColorUtility.TryParseHtmlString(ClothesTwo.shirtPantsColor, out shirtPantsColor);
            Color shoesColor;
            ColorUtility.TryParseHtmlString(ClothesTwo.shoesColor, out shoesColor);

            shirt.color = shirtPantsColor;
            pants.color = shirtPantsColor;
            shoes.color = shoesColor;
        }

        else
        {
            txtNoMoney.text = "You don't own that outfit.";
            StartCoroutine(DeleteText());
        }
    }

    public void ItemThree()
    {
        if (ClothesThree.owned)
        {
            Color shirtPantsColor;
            ColorUtility.TryParseHtmlString(ClothesThree.shirtPantsColor, out shirtPantsColor);
            Color shoesColor;
            ColorUtility.TryParseHtmlString(ClothesThree.shoesColor, out shoesColor);

            shirt.color = shirtPantsColor;
            pants.color = shirtPantsColor;
            shoes.color = shoesColor;
        }

        else
        {
            txtNoMoney.text = "You don't own that outfit.";
            StartCoroutine(DeleteText());
        }
    }

    public void ItemFour()
    {
        if (ClothesFour.owned)
        {
            Color shirtPantsColor;
            ColorUtility.TryParseHtmlString(ClothesFour.shirtPantsColor, out shirtPantsColor);
            Color shoesColor;
            ColorUtility.TryParseHtmlString(ClothesFour.shoesColor, out shoesColor);

            shirt.color = shirtPantsColor;
            pants.color = shirtPantsColor;
            shoes.color = shoesColor;
        }

        else
        {
            txtNoMoney.text = "You don't own that outfit.";
            StartCoroutine(DeleteText());
        }
    }

    public void ItemFive()
    {
        if (ClothesFive.owned)
        {
            Color shirtPantsColor;
            ColorUtility.TryParseHtmlString(ClothesFive.shirtPantsColor, out shirtPantsColor);
            Color shoesColor;
            ColorUtility.TryParseHtmlString(ClothesFive.shoesColor, out shoesColor);

            shirt.color = shirtPantsColor;
            pants.color = shirtPantsColor;
            shoes.color = shoesColor;
        }

        else
        {
            txtNoMoney.text = "You don't own that outfit.";
            StartCoroutine(DeleteText());
        }
    }

    private IEnumerator DeleteText()
    {
        yield return new WaitForSeconds(3);
        txtNoMoney.text = "";
    }
}
