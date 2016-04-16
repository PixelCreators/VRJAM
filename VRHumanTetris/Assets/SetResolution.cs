using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetResolution : MonoBehaviour
{
    private RawImage rawImage;


    void Awake()
    {
        rawImage = GetComponent<RawImage>();
    }

	// Use this for initialization
	void Start ()
	{
	    rawImage.mainTexture.width = Screen.width;
	    rawImage.mainTexture.height = Screen.height;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
