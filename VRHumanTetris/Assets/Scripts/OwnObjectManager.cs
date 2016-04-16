using UnityEngine;
using System.Collections;
using System.Runtime.Serialization;

public class OwnObjectManager : MonoBehaviour
{
    public GameObject LeftWall;
    public GameObject RightWall;
    public static OwnObjectManager Instance;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
