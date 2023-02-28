using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_movement : MonoBehaviour
{
    [SerializeField] private float _speed;


    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }
}
