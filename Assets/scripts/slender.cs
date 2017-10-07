using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slender : MonoBehaviour {

    private float gameTime = 500;
    private GameObject gameScript;
    private float tempTime;

    public GameObject prefabSlenderman;

    // Use this for initialization
    void Start ()
    {
        gameScript = GameObject.Find("Main Camera"); Time.timeScale = 5;
    }
	
	// Update is called once per frame
	void Update () { //TODO: project chasing alghorytm

        print(gameTime);
        
        gameTime -= Time.deltaTime;

        if(Mathf.Round(gameTime) % 25 == 0)
        {
            Move();
            tempTime = gameTime;
        }

        if(tempTime - gameTime == 15 && gameTime > 10 && false)
            transform.position = new Vector3(-10, -10, -10);


    }

    private void OnCollisionEnter(Collision collision)
    {
        //print(collision.gameObject.name);
        if (collision.gameObject.tag == "MainCamera")
        {
            //TODO end game
        }

        if (collision.gameObject.name == "XR")
            Move();
    }

    private void Move() //TODO: enhance spawning alghorythm
    {
        float distance = gameTime/10;
        float x = RandomPositionX(distance);
        transform.position = new Vector3(x, 0, RandomPositionY(x, distance));
    }

    private float RandomPositionX(float r)
    {
        return Random.Range(gameScript.transform.position.x - r, gameScript.transform.position.x + r);
    }

    private float RandomPositionY(float x, float r)
    {
        float Y;

        Y = gameScript.transform.position.y + (Random.Range(-1, 1) < 0 ? Mathf.Sqrt(r * r - ((x - gameScript.transform.position.x) * (x - gameScript.transform.position.x))) : -1 * Mathf.Sqrt(r * r - ((x - gameScript.transform.position.x) * (x - gameScript.transform.position.x))));

        return Y;
    }

}
