using UnityEngine;
using System.Collections.Generic;

public class OwnObjectManager : MonoBehaviour
{
    [SerializeField]
    public List<List<GameObject>> Walls;
    public static OwnObjectManager Instance;

	// Use this for initialization
    public void Start () { 
        Walls = new List<List<GameObject>>();
	}

    public void Update ()
	{
	}

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public int AddToList(GameObject wall, GameObject wallFull, GameObject wallLeft, GameObject wallRight)
    {
        Walls.Add(new List<GameObject>());
        Walls[Walls.Count - 1].Add(wall);
        Walls[Walls.Count - 1].Add(wallFull);
        Walls[Walls.Count - 1].Add(wallLeft);
        Walls[Walls.Count - 1].Add(wallRight);

        return Walls.Count - 1;
    }

}
