using UnityEngine;
using System.Collections;

public class WallLeft : MonoBehaviour {

	// Use this for initialization
	void Start () {
        OwnObjectManager.Instance.LeftWall = this.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
