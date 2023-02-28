using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_damage : MonoBehaviour
{
    public static Rocket_damage instance;
    public float Damage;

    private void Start()
    {
        instance = this;
        Damage = PlayerPrefs.GetFloat("Hero damage");
    }
    private void OnTriggerEnter(Collider other)
    {
        Enemy_health enemyHealth = other.GetComponent<Enemy_health>();
        if (enemyHealth != null)
        {
            enemyHealth.EnemyTakeDamage(Damage);
            Destroy(gameObject);
        }
    }
}
