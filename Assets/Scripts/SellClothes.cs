using System.Collections;
using TMPro;
using UnityEngine;

public class SellClothes : MonoBehaviour
{
    [SerializeField] private TMP_Text txtNoMoney;
    [SerializeField] private Money money;
    [SerializeField] private int prizeOneTwo;
    [SerializeField] private int prizeThreeFour;
    [SerializeField] private int prizeFive;

    public void ItemOne()
    {
        if (TotalNumOfClothes.amount > 1)
        {
            if (ClothesOne.owned)
            {
                money.amount += prizeOneTwo;
                ClothesOne.owned = false;
                money.WriteOut(money.amount);
                TotalNumOfClothes.amount--;
            }

            else
            {
                txtNoMoney.text = "You've already sold that outfit.";
                StartCoroutine(DeleteText());
            }
        }

        else
        {
            txtNoMoney.text = "You can't sell the last outfit!";
            StartCoroutine(DeleteText());
        }
    }

    public void ItemTwo()
    {
        if (TotalNumOfClothes.amount > 1)
        {
            if (ClothesTwo.owned)
            {
                money.amount += prizeOneTwo;
                ClothesTwo.owned = false;
                money.WriteOut(money.amount);
                TotalNumOfClothes.amount--;
            }

            else
            {
                txtNoMoney.text = "You've already sold that outfit.";
                StartCoroutine(DeleteText());
            }
        }

        else
        {
            txtNoMoney.text = "You can't sell the last outfit!";
            StartCoroutine(DeleteText());
        }
    }

    public void ItemThree()
    {
        if (TotalNumOfClothes.amount > 1)
        {
            if (ClothesThree.owned)
            {
                money.amount += prizeThreeFour;
                ClothesThree.owned = false;
                money.WriteOut(money.amount);
                TotalNumOfClothes.amount--;
            }

            else
            {
                txtNoMoney.text = "You've already sold that outfit.";
                StartCoroutine(DeleteText());
            }
        }

        else
        {
            txtNoMoney.text = "You can't sell the last outfit!";
            StartCoroutine(DeleteText());
        }
    }

    public void ItemFour()
    {
        if (TotalNumOfClothes.amount > 1)
        {
            if (ClothesFour.owned)
            {
                money.amount += prizeThreeFour;
                ClothesFour.owned = false;
                money.WriteOut(money.amount);
                TotalNumOfClothes.amount--;
            }

            else
            {
                txtNoMoney.text = "You've already sold that outfit.";
                StartCoroutine(DeleteText());
            }
        }

        else
        {
            txtNoMoney.text = "You can't sell the last outfit!";
            StartCoroutine(DeleteText());
        }
    }

    public void ItemFive()
    {
        if (TotalNumOfClothes.amount > 1)
        {
            if (ClothesFive.owned)
            {
                money.amount += prizeFive;
                ClothesFive.owned = false;
                money.WriteOut(money.amount);
                TotalNumOfClothes.amount--;
            }

            else
            {
                txtNoMoney.text = "You've already sold that outfit.";
                StartCoroutine(DeleteText());
            }
        }

        else
        {
            txtNoMoney.text = "You can't sell the last outfit!";
            StartCoroutine(DeleteText());
        }
    }

    private IEnumerator DeleteText()
    {
        yield return new WaitForSeconds(3);
        txtNoMoney.text = "";
    }
}
