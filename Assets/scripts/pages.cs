using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pages : MonoBehaviour {

    private GameObject gameScript;

	// Use this for initialization
	void Start () {
        gameScript = GameObject.Find("Main Camera");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        //print(collision.gameObject.name);
        if (collision.gameObject.tag == "MainCamera")
        {
            gameScript.transform.GetComponent<game>().Gaming();
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name == "XR")
            transform.position = new Vector3
                (
                    Random.Range(-gameScript.transform.GetComponent<game>().radius, gameScript.transform.GetComponent<game>().radius),
                    gameScript.transform.GetComponent<game>().height,
                    Random.Range(-gameScript.transform.GetComponent<game>().radius, gameScript.transform.GetComponent<game>().radius)
                );
    }
}
