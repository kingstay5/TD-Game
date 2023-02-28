using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Money_earn : MonoBehaviour
{
    public static Money_earn instance;

    [SerializeField] private TextMeshProUGUI _moneyText;
    public float Money;
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        _moneyText.text = Money.ToString("F1");
    }

    public void KillReward()
    {
        Money += Enemy_reward.instance.KillReward;
    }
}
