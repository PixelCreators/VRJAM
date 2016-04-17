using UnityEngine;
using System.Collections;
using GamepadInput;

public class ControlRightArm : MonoBehaviour
{
    private Vector3 startRotation;

    void Start()
    {
        startRotation = transform.localEulerAngles;
    }

    void Update()
    {
        var rightStick = GamePad.GetAxis(GamePad.Axis.RightStick, GamePad.Index.Any);

        transform.localEulerAngles = new Vector3(startRotation.x, rightStick.y * 100, startRotation.z);

    }
}
