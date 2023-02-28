using TMPro;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    [Space]
    [SerializeField] protected string UpgradeName;
    [Space]
    [SerializeField] protected float UpgradeMultiply;
    [SerializeField] protected float PriceMultiply;
    [SerializeField] protected float UpgradePrice;
    [Space]
    protected int Level = 1;
    [Space]
    [SerializeField] protected Money_earn MoneyEarn;
    [Space]
    [SerializeField] protected TextMeshProUGUI ImprovedValueText;
    [SerializeField] protected TextMeshProUGUI PriceText;
    [SerializeField] protected TextMeshProUGUI LevelText;

    private void Awake()
    {
        MoneyEarn = FindObjectOfType<Money_earn>();
    }

    public void UpdateUpgrade()
    {
        UpgradePrice *= PriceMultiply;
        Level++;
        Money_earn.instance.Money -= UpgradePrice;
    }
}
