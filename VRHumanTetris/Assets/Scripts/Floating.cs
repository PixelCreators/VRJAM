using UnityEngine;

public class Floating : MonoBehaviour {
    public float WaterLevel;
    public float Height;
    public float BounceDamp;
    public Vector3 BuoyancyCentreOffset;

    private Rigidbody _rb;
    private float _forceFactor;
    private Vector3 _actionPoint;
    private Vector3 _uplift;


    public void Start ()
    {
        _rb = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
    public void Update ()
	{
	    _actionPoint = transform.position + transform.TransformDirection(BuoyancyCentreOffset);
	    _forceFactor = 1f - ((_actionPoint.y - WaterLevel)/Height);

	    if (_forceFactor > 0f)
	    {
	        _uplift = -Physics.gravity*(_forceFactor - _rb.velocity.y*BounceDamp);
	        _rb.AddForceAtPosition(_uplift, _actionPoint);
	    }
	}


}
