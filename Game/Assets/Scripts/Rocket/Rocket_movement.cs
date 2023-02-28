using UnityEngine;

public class Rocket_movement : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    

    private void FixedUpdate()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _speed);
    }
}
