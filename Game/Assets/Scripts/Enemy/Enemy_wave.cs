using TMPro;
using UnityEngine;

public class Enemy_wave : MonoBehaviour
{
    public static Enemy_wave instance;
    [Header("Enemy prefab")]
    [SerializeField] private Enemy_health[] _enemyHealth;
    [SerializeField] private Enemy_damage[] _enemyDamage;
    [SerializeField] private Enemy_reward[] _enemyReward;
    [Header("Wave stats")]
    [SerializeField] private int _currentWave;
    [SerializeField] private int _currentKills;
    [SerializeField] private int _targetKills;
    [Header("Multiply value")]
    [SerializeField] private float _healthBuffMultiply;
    [SerializeField] private float _damageBuffMultiply;
    [SerializeField] private float _killRewardMultiply;
    [Header("Texts")]
    [SerializeField] private TextMeshProUGUI _targetKillsText;
    [SerializeField] private TextMeshProUGUI _currentWaveText;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        _currentWaveText.text = _currentWave.ToString();
        _targetKillsText.text = _currentKills + "/" + _targetKills;
        CompleteWave();
    }

    public void CompleteWave()
    {
        if (_currentKills >= _targetKills)
        {
            _currentWave++;
            _currentKills = 0;
            _targetKills += 5;
            EnemyBuff();
            EnemyStatsUpdate();
        }
    }
    public void KillDetect()
    {
        _currentKills += 1;
    }

    private void EnemyBuff()
    {
        PlayerPrefs.SetFloat("Enemy health", Enemy_health.instance.MaxHealth * _healthBuffMultiply);
        PlayerPrefs.SetFloat("Enemy damage", Enemy_damage.instance.Damage * _damageBuffMultiply);
        PlayerPrefs.SetFloat("Enemy reward", Enemy_reward.instance.KillReward * _killRewardMultiply);
    }
    private void EnemyStatsUpdate()
    {
        PlayerPrefs.GetFloat("Enemy health");
        PlayerPrefs.GetFloat("Enemy damage");
        PlayerPrefs.GetFloat("Enemy reward");
    }
}
