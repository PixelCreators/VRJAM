using UnityEngine;
using System.Collections;

public class UpdatePositon : MonoBehaviour
{

    public Transform objectPositionToUpdate;
    public Vector3 offset;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        transform.position = objectPositionToUpdate.position + offset;
    }
}
