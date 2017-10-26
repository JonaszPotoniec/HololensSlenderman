using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMEOVER : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (GameObject.Find("settings").GetComponent<settings>().gameover)
            this.gameObject.SetActive(true);
        else
            this.gameObject.SetActive(false);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
