using UnityEngine;
using System.Collections;

public class UpdatePosition : MonoBehaviour
{
    public Transform Neck;


	void Start ()
    {
	
	}
	
	void Update ()
	{
	    transform.position = Neck.transform.position + transform.position;
	}
}
