using UnityEngine;
using System.Collections;
using GamepadInput;

public class ControlLeftArm : MonoBehaviour
{
    private Vector2 leftStick;

    void Update ()
	{
        leftStick = GamePad.GetAxis(GamePad.Axis.LeftStick, GamePad.Index.Any);
	}
   
    public void LateUpdate()
    {
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, leftStick.y * 100, transform.localEulerAngles.z);
    }
}
