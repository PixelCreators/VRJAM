using UnityEngine;
using System.Collections;
using System.Runtime.Serialization;

public class OwnObjectManager : MonoBehaviour
{
    public GameObject FullWall;
    public GameObject LeftWall;
    public GameObject RightWall;
    public static OwnObjectManager Instance;

	// Use this for initialization
	void Start () {
	}
	
	void Update ()
	{
	    Debug.Log(LeftWall.active);
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

}
