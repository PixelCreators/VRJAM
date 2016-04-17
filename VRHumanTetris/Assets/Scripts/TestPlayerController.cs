using UnityEngine;

public class TestPlayerController : MonoBehaviour
{
    public float Speed;
    public float JumpSpeed;

    private Rigidbody _rb;

    public void Start () {
        _rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        _rb.velocity = (movement*Speed) + new Vector3(0.0f, _rb.velocity.y, 0.0f);
    }
}
