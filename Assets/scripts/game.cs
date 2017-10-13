using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour {

    public int points = 0;
    public GameObject tekst;
    public GameObject prefabPage;
    public GameObject prefabSlenderman;
    public GameObject rotatePleaseText;
    public float radius = 20.0f;
    public float height = 0;

    private GameObject settingsObject;

    // Use this for initialization
    void Start () {

        settingsObject = GameObject.Find("settings");

        if (settingsObject.GetComponent<settings>().oneRoomMode == false)
        {
            for (int z = 0; z < 10; z++)
            {
                Instantiate(prefabPage, new Vector3(Random.Range(-radius, radius), height, Random.Range(-radius, radius)), Quaternion.identity);
            }
        }
        else
        {
            float rotateStart = transform.rotation.y;
            rotatePleaseText.SetActive(true);
            /*
            float f1, f2, f3, f4;
            bool b1 = false, b2 = false, b3 = false, b4 = false;
            while (!b1 && !b2 && !b3 && !b4)
            {

                if(Mathf.Round == 0)
                    

            }*/

        }

	}
	
	// Update is called once per frame
	void Update () {

    }

    public void Gaming()
    {

        points++;
        if(points == 10)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            if(points == 2)
                Instantiate(prefabSlenderman, new Vector3(-10, -10, -10), Quaternion.identity);

        tekst.transform.GetComponent<TextMesh>().text = points + "/10";
        
    }

}
