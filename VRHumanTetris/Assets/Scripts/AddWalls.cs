using UnityEngine;
using System.Collections;

public class AddWalls : MonoBehaviour
{

    public int wallindex;
    public GameObject Wall;
    public GameObject WallFull;
    public GameObject WallLeft;
    public GameObject WallRight;

	// Use this for initialization
	void Start () {

        wallindex = OwnObjectManager.Instance.AddToList(Wall, WallFull, WallLeft, WallRight);
        OwnObjectManager.Instance.Walls[wallindex][0].SetActive(true);
        OwnObjectManager.Instance.Walls[wallindex][1].SetActive(true);
        OwnObjectManager.Instance.Walls[wallindex][2].SetActive(false);
        OwnObjectManager.Instance.Walls[wallindex][3].SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
    }
}
