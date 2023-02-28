using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_reward : MonoBehaviour
{
    public static Enemy_reward instance;

    public float KillReward;

    private void Awake()
    {
        instance = this;
        KillReward = PlayerPrefs.GetFloat("Enemy reward");
    }
}
