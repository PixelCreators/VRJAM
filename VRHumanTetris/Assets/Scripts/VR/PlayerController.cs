using UnityEngine;
using UnityEngine.VR;
using System.Collections;
using GamepadInput;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    public bool trigger;

    void Awake()
    {
        Instance = this;
    }
	
	void Update ()
	{
        if(trigger)
            return;

	    if (Input.GetKeyDown(KeyCode.A) || GamePad.GetButtonDown(GamePad.Button.A, GamePad.Index.Any))
	    {
	        InputTracking.Recenter();
	        trigger = true;
	    }
    }
}
