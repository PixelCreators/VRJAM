using UnityEngine;
using System.Collections;
using GamepadInput;

public class ControlLeftArm : MonoBehaviour
{ 
	void Update ()
	{
	    var leftStick = GamePad.GetAxis(GamePad.Axis.LeftStick, GamePad.Index.Any);

	    transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, leftStick.y * 100, transform.localEulerAngles.z);

	}
}
