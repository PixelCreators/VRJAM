using UnityEngine;
using System.Collections;
using GamepadInput;

public class ControlRightArm : MonoBehaviour
{
    private Vector3 startRotation;
    private Vector2 rightStick;

    void Start()
    {
        startRotation = transform.localEulerAngles;
    }

    void Update()
    {
        rightStick = GamePad.GetAxis(GamePad.Axis.RightStick, GamePad.Index.Any);

        
    }

    void LateUpdate()
    {
        transform.localEulerAngles = new Vector3(startRotation.x, rightStick.y * 100 + startRotation.y, startRotation.z);
    }
}
