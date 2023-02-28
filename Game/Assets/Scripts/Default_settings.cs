using UnityEngine;

public class Default_settings : MonoBehaviour
{
    public static Default_settings instance;
    [Header("Player settings")]
    [SerializeField] private float _playerDamage;
    [SerializeField] private float _playerAttackSpeed;
    [Header("Enemy settings")]
    [SerializeField] private float _enemyDamage;
    [SerializeField] private float _enemyMaxHealth;
    [SerializeField] private float _enemyKillReward;

    void Awake()
    {
        instance = this;

        Application.targetFrameRate = 300;
        PlayerPrefs.SetFloat("Hero damage", _playerDamage);
        PlayerPrefs.SetFloat("Attack speed", _playerAttackSpeed);
        PlayerPrefs.SetFloat("Enemy damage", _enemyDamage);
        PlayerPrefs.SetFloat("Enemy health", _enemyMaxHealth);
        PlayerPrefs.SetFloat("Enemy reward", _enemyKillReward);
    }

}
