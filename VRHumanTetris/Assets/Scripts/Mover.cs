using UnityEngine;

public class Mover : MonoBehaviour
{

    public float Speed;

    //private Transform _player;
    private Rigidbody _rb;

    public void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.velocity = transform.up * Speed;
    }
}
