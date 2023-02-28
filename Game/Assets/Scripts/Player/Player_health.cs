using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_health : MonoBehaviour
{
    public static Player_health instance;

    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _currentHealth;
    [SerializeField] private Image _healthBar;

    private void Start()
    {
        instance = this;
        _currentHealth = _maxHealth;
        _healthText.text = _currentHealth.ToString("F0");
    }
    private void Update()
    {
        _healthBar.fillAmount = (float)(_currentHealth / _maxHealth);
    }
    public void BarricadeTakeDamage(float _damage)
    {
        _currentHealth -= _damage;
        if (_currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            PlayerPrefs.DeleteAll();
        }
        _healthText.text = _currentHealth.ToString();
    }
}
