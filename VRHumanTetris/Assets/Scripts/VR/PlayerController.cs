using UnityEngine;
using UnityEngine.VR;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private VRNode node;

    void Start ()
    {
        node = VRNode.Head;
    }
	
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.A))
            InputTracking.Recenter();
        
    }
}
