using UnityEngine;

public class Upgrade_attackSpeed : Upgrade
{
    private Rocket_spawn _attackSpeed;
    void Awake()
    {
        _attackSpeed = FindObjectOfType<Rocket_spawn>();
    }
    private void Update()
    {
        ImprovedValueText.text = _attackSpeed.AttackSpeed.ToString("F1");
        PriceText.text = UpgradePrice.ToString("F1");
        LevelText.text = Level.ToString();
    }
    public void AttackSpeedUpgrade()
    {
        if (MoneyEarn.Money > UpgradePrice)
        {
            UpdateUpgrade();
            _attackSpeed.AttackSpeed = PlayerPrefs.GetFloat(UpgradeName);
            PlayerPrefs.SetFloat(UpgradeName, _attackSpeed.AttackSpeed * UpgradeMultiply);
        }
    }

    public void StatsUpdate()
    {
        _attackSpeed.AttackSpeed = PlayerPrefs.GetFloat("Attack speed");
    }
}
