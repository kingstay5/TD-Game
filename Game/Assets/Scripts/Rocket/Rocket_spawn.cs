using UnityEngine;

public class Rocket_spawn : MonoBehaviour
{
    public static Rocket_spawn instance;

    public float AttackSpeed;

    [SerializeField] private GameObject _rocket;
    [SerializeField] private GameObject _spawnPoint;
    [SerializeField] private float _countdown;

    private void Start()
    {
        AttackSpeed = PlayerPrefs.GetFloat("Attack speed");
    }
    private void Update()
    {
        if (_countdown <= 0)
        {
            Instantiate(_rocket, _spawnPoint.transform.position, _rocket.transform.rotation);
            _countdown = 1 / AttackSpeed;
        }

        _countdown -= Time.deltaTime;

    }
}
