using System.Collections;
using TMPro;
using UnityEngine;

public class BuyClothes : MonoBehaviour
{
    [SerializeField] private TMP_Text txtNoMoney;
    [SerializeField] private Money money;
    [SerializeField] private int prizeOneTwo;
    [SerializeField] private int prizeThreeFour;
    [SerializeField] private int prizeFive;

    public void ItemOne()
    {
        if (!ClothesOne.owned)
        {
            if (money.amount >= prizeOneTwo)
            {
                money.amount -= prizeOneTwo;
                ClothesOne.owned = true;
                money.WriteOut(money.amount);
                TotalNumOfClothes.amount++;
            }

            else
            {
                txtNoMoney.text = "NO MONEY!";
                StartCoroutine(DeleteText());
            }
        }

        else
        {
            txtNoMoney.text = "You already own that outfit.";
            StartCoroutine(DeleteText());
        }
    }

    public void ItemTwo()
    {
        if (!ClothesTwo.owned)
        {
            if (money.amount >= prizeOneTwo)
            {
                money.amount -= prizeOneTwo;
                ClothesTwo.owned = true;
                money.WriteOut(money.amount);
                TotalNumOfClothes.amount++;
            }

            else
            {
                txtNoMoney.text = "NO MONEY!";
                StartCoroutine(DeleteText());
            }
        }

        else
        {
            txtNoMoney.text = "You already own that outfit.";
            StartCoroutine(DeleteText());
        }
    }

    public void ItemThree()
    {
        if (!ClothesThree.owned)
        {
            if (money.amount >= prizeThreeFour)
            {
                money.amount -= prizeThreeFour;
                ClothesThree.owned = true;
                money.WriteOut(money.amount);
                TotalNumOfClothes.amount++;
            }

            else
            {
                txtNoMoney.text = "NO MONEY!";
                StartCoroutine(DeleteText());
            }
        }

        else
        {
            txtNoMoney.text = "You already own that outfit.";
            StartCoroutine(DeleteText());
        }
    }

    public void ItemFour()
    {
        if (!ClothesFour.owned)
        {
            if (money.amount >= prizeThreeFour)
            {
                money.amount -= prizeThreeFour;
                ClothesFour.owned = true;
                money.WriteOut(money.amount);
                TotalNumOfClothes.amount++;
            }

            else
            {
                txtNoMoney.text = "NO MONEY!";
                StartCoroutine(DeleteText());
            }
        }

        else
        {
            txtNoMoney.text = "You already own that outfit.";
            StartCoroutine(DeleteText());
        }
    }

    public void ItemFive()
    {
        if (!ClothesFive.owned)
        {
            if (money.amount >= prizeFive)
            {
                money.amount -= prizeFive;
                ClothesFive.owned = true;
                money.WriteOut(money.amount);
                TotalNumOfClothes.amount++;
            }

            else
            {
                txtNoMoney.text = "NO MONEY!";
                StartCoroutine(DeleteText());
            }
        }

        else
        {
            txtNoMoney.text = "You already own that outfit.";
            StartCoroutine(DeleteText());
        }
    }

    private IEnumerator DeleteText()
    {
        yield return new WaitForSeconds(3);
        txtNoMoney.text = "";
    }
}
