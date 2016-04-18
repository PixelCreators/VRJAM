using UnityEngine;
using System.Collections;
using GamepadInput;

public class DisableScript : MonoBehaviour {
    
	
	// Update is called once per frame
	void Update () {
	    if(GamePad.GetButtonDown(GamePad.Button.A, GamePad.Index.Any))
            gameObject.SetActive(false);
	}
}
