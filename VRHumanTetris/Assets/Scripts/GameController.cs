using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    private bool gameOver;
    private bool restart;

    void Start () {
        restart = false;
        gameOver = false;
    }
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    public void GameOver()
    {
        gameOver = true;
    }
}
