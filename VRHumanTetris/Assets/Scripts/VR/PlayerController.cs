using UnityEngine;
using UnityEngine.VR;
using System.Collections;
using GamepadInput;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    void Awake()
    {
        Instance = this;
    }
	
	void Update ()
	{
	    if (Input.GetKeyDown(KeyCode.A) || GamePad.GetButtonDown(GamePad.Button.A, GamePad.Index.Any)) 
            InputTracking.Recenter();
    }
}
