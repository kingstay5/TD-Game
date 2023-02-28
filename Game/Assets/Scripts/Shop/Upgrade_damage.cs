using UnityEngine;

public class Upgrade_damage : Upgrade
{
    private void Update()
    {
        ImprovedValueText.text = Rocket_damage.instance.Damage.ToString("F1");
        PriceText.text = UpgradePrice.ToString("F1");
        LevelText.text = Level.ToString();
    }
    public void DamageUpgrade()
    {
        if (Money_earn.instance.Money > UpgradePrice)
        {
            UpdateUpgrade();
            PlayerPrefs.SetFloat(UpgradeName, Rocket_damage.instance.Damage * UpgradeMultiply);
        }
    }
    public void StatsUpdate()
    {
        Rocket_damage.instance.Damage = PlayerPrefs.GetFloat("Hero damage");
    }
}
