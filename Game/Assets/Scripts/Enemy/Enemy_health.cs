using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_health : MonoBehaviour
{
    public static Enemy_health instance;
    [Space]
    public float MaxHealth;
    [Space]
    [SerializeField] private Image _healthBar;
    [SerializeField] private GameObject _deathEffect;
    [Space]
    private float _currentHealth;
    private void Start()
    {
        instance = this;
        MaxHealth = PlayerPrefs.GetFloat("Enemy health");
        _currentHealth = MaxHealth;
    }
    private void Update()
    {
        _healthBar.fillAmount = (float)(_currentHealth / MaxHealth);
    }

    public void EnemyTakeDamage(float damage)
    {
        _currentHealth -= damage;
        if (_currentHealth <= 0)
        {
            Money_earn.instance.KillReward();
            Enemy_wave.instance.KillDetect();
            Instantiate(_deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
