using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settings : MonoBehaviour {

    public bool oneRoomMode = true;
    public bool gameover = false;
    public bool won = false;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(transform.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void oneRoom(bool state)
    {
        oneRoomMode = state;
        return;
    }

    void startGame()
    {
        SceneManager.LoadScene(1);
    }

    void goToMenu(bool lost)
    {
        if (lost)
        {
            gameover = true;
        }
        else
        {
            won = true;
        }

        SceneManager.LoadScene(0);
    }

    public void resetGame()
    {
        gameover = false;
        won = false;
    }
}
