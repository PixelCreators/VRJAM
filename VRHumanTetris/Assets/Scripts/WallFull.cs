using UnityEngine;
using System.Collections;

public class WallFull : MonoBehaviour {

	// Use this for initialization
	void Start () {
        OwnObjectManager.Instance.FullWall = this.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
