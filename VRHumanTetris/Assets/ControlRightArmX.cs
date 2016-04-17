using UnityEngine;
using GamepadInput;

public class ControlRightArmX : MonoBehaviour
{
    public Vector2 rightStick;

    public void Update()
    {
        rightStick = GamePad.GetAxis(GamePad.Axis.RightStick, GamePad.Index.Any);


    }

    public void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, rightStick.x * 100 + 321.43f,
            transform.rotation.eulerAngles.z);
    }
}