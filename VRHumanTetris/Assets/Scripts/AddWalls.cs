using UnityEngine;

public class AddWalls : MonoBehaviour
{
    public int Wallindex;
    public GameObject Wall;
    public GameObject WallFull;
    public GameObject WallLeft;
    public GameObject WallRight;

    public void Start ()
    {
            Wallindex = OwnObjectManager.Instance.AddToList(Wall, WallFull, WallLeft, WallRight);
            OwnObjectManager.Instance.Walls[Wallindex][0].SetActive(true);
            OwnObjectManager.Instance.Walls[Wallindex][1].SetActive(true);
            OwnObjectManager.Instance.Walls[Wallindex][2].SetActive(false);
            OwnObjectManager.Instance.Walls[Wallindex][3].SetActive(false);
    }
}
