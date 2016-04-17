using UnityEngine;
using GamepadInput;

public class ControlLeftArmX : MonoBehaviour {
    public void Update()
    {
        var leftStick = GamePad.GetAxis(GamePad.Axis.LeftStick, GamePad.Index.Any);

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, leftStick.x*100 + 180,
            transform.rotation.eulerAngles.z);

    }
}