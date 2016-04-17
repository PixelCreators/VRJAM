using UnityEngine;

public class NoRbMover : MonoBehaviour
{

    public float Speed;

    public void Start ()
    {
        
    }

    public void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - Speed * Time.deltaTime);
    }
}
