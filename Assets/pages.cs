using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pages : MonoBehaviour {

    public GameObject gameScript;

	// Use this for initialization
	void Start () {
        gameScript = GameObject.Find("Main Camera");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
        if (collision.gameObject.tag == "MainCamera")
            gameScript.transform.GetComponent<game>().Gaming();
        Destroy(this.gameObject);
    }

}
