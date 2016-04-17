using UnityEngine;
using System.Collections;
using System.Threading;

public class Floating : MonoBehaviour {
    public float WaterLevel;
    public float Height;
    public float bounceDamp;
    public Vector3 buoyancyCentreOffset;

    private Rigidbody rb;
    private float forceFactor;
    private Vector3 actionPoint;
    private Vector3 uplift;




    void Start ()
    {
        rb = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update ()
	{
	    actionPoint = transform.position + transform.TransformDirection(buoyancyCentreOffset);
	    forceFactor = 1f - ((actionPoint.y - WaterLevel)/Height);

	    if (forceFactor > 0f)
	    {
	        uplift = -Physics.gravity*(forceFactor - rb.velocity.y*bounceDamp);
	        rb.AddForceAtPosition(uplift, actionPoint);
	    }
	}


}
