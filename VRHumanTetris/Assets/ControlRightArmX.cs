using UnityEngine;
using GamepadInput;

public class ControlRightArmX : MonoBehaviour
{
    public void Update()
    {
        var rightStick = GamePad.GetAxis(GamePad.Axis.RightStick, GamePad.Index.Any);

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, rightStick.x * 100 + 90,
            transform.rotation.eulerAngles.z);

    }
}