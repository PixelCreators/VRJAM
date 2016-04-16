using UnityEngine;
using System.Collections;

public class WallRight : MonoBehaviour {

	// Use this for initialization
	void Start () {
        OwnObjectManager.Instance.RightWall = this.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
