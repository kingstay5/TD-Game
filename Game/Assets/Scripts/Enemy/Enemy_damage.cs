using UnityEngine;

public class Enemy_damage : MonoBehaviour
{
    public static Enemy_damage instance;
    public float Damage;

    private void Awake()
    {
        instance= this;
        Damage = PlayerPrefs.GetFloat("Enemy damage");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player_health.instance.BarricadeTakeDamage(Damage);
            Destroy(gameObject);
        }
    }
}
