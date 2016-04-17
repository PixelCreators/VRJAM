using UnityEngine;

public class TestPlayerController : MonoBehaviour
{
    public float Speed;
    public float JumpSpeed;

    private Rigidbody _rb;

    public void Start () {
        _rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        if (Input.GetButton("Jump"))
        {
            //rb.AddForce(Vector3.up * JumpSpeed);
            transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
        }
    }

    public void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        _rb.velocity = (movement*Speed) + new Vector3(0.0f, _rb.velocity.y, 0.0f);
    }
}
