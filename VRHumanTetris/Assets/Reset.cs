using UnityEngine;
using System.Collections;
using GamepadInput;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(GamePad.GetButtonDown(GamePad.Button.A, GamePad.Index.Any))
            SceneManager.LoadScene("Level");
	}
}
