using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointsController : MonoBehaviour
{
    public static Text text;

	// Use this for initialization
	void Start ()
	{
	    text = GetComponent<Text>();
	    text.text = "0 YouN00b";
	}

    public static void UpdateText(int Text)
    {

        text.text = Text.ToString();
    }

}
