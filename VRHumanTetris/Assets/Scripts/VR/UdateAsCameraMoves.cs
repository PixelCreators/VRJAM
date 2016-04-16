using UnityEngine;
using System.Collections;

public class UdateAsCameraMoves : MonoBehaviour
{

    public GameObject OculusCamera;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void FixedUpdate()
    {
        transform.position = OculusCamera.transform.position;
        transform.rotation = OculusCamera.transform.rotation;
    }
}
