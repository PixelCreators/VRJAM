using UnityEngine;
using System.Collections;

public class NoRbMover : MonoBehaviour
{

    public float Speed;

    void Start ()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - Speed);
    }
}
