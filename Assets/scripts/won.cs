using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class won : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (GameObject.Find("settings").GetComponent<settings>().won)
            this.gameObject.SetActive(true);
        else
            this.gameObject.SetActive(false);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
