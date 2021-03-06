﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slender : MonoBehaviour {

    public float gameTime = 500;
    private GameObject gameScript;
    private float tempTime;

    public GameObject prefabSlenderman;

    // Use this for initialization
    void Start ()
    {
        gameScript = GameObject.Find("Main Camera"); //Time.timeScale = 5;
    }
	
	// Update is called once per frame
	void Update () { //TODO: project chasing alghorytm

        transform.LookAt(Camera.main.transform.position, Vector3.up);

        gameTime -= Time.deltaTime;

        if(gameTime > 30)
        {
            if(Mathf.Round(gameTime) % 25 == 0)
            {
                Move();
                tempTime = gameTime;
            }

            if(tempTime - gameTime == 15)
                transform.position = new Vector3(-10, -10, -10);
        }
        else
        {
            if (transform.position.z > gameScript.transform.position.z)
            {
                transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
            }
            else
            if (transform.position.z < gameScript.transform.position.z)
            {
                transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
            }
            if(transform.position.x > gameScript.transform.position.x)
            {
                transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);
            }
            else
            if (transform.position.x < gameScript.transform.position.x)
            {
                transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);
            }


        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        //print(collision.gameObject.name);
        if (collision.gameObject.tag == "MainCamera")
        {
            GameObject.Find("settings").SendMessageUpwards("goToMenu");
        }

        if (collision.gameObject.name == "XR")
            Move();
    }

    private void Move() //TODO: enhance spawning alghorythm
    {
        
        float distance = gameTime/10;
        float x = RandomPositionX(distance);
        transform.position = new Vector3(x, 0, RandomPositionY(x, distance));

        //y=(cos(x/155)+1.8)*5

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
