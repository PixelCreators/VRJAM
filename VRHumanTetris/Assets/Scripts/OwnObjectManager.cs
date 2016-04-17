using UnityEngine;
using System.Collections;
using System.Runtime.Serialization;
using System.Collections.Generic;
using UnityEngine.Networking.Match;

public class OwnObjectManager : MonoBehaviour
{
    [SerializeField]
    public List<List<GameObject>> Walls;
    public static OwnObjectManager Instance;

	// Use this for initialization
	void Start () { 
        Walls = new List<List<GameObject>>();
	}
	
	void Update ()
	{
	}

    void Awake()
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

    public int AddToList(GameObject Wall, GameObject WallFull, GameObject WallLeft, GameObject WallRight)
    {
        Walls.Add(new List<GameObject>());
        Walls[Walls.Count - 1].Add(Wall);
        Walls[Walls.Count - 1].Add(WallFull);
        Walls[Walls.Count - 1].Add(WallLeft);
        Walls[Walls.Count - 1].Add(WallRight);

        return Walls.Count - 1;
    }

}
