using UnityEngine;
using GamepadInput;

public class ControlLeftArmX : MonoBehaviour
{
    private Vector2 leftStick;

    public void Update()
    {
        leftStick = GamePad.GetAxis(GamePad.Axis.LeftStick, GamePad.Index.Any);
    }

    public void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, leftStick.x * 100 + 302.6573f,
            transform.rotation.eulerAngles.z);
    }
}