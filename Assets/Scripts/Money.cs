using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{
    [SerializeField] private TMP_Text txtMoney;

    public int amount;

    private void Start()
    {
        amount = 5000;
        WriteOut(amount);
    }

    public void WriteOut(int amount)
    {
        txtMoney.text = amount.ToString() + " £";
    }
}
