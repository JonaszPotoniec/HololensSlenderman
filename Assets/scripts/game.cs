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
    public float f1 = 0, f2 = 0, f3 = 0, f4 = 0;
    public float rotateStart;
    public Texture bloooood;

    private GameObject settingsObject;

    // Use this for initialization
    void Start () {

        settingsObject = GameObject.Find("settings");

        settingsObject.GetComponent<settings>().resetGame();

        if (settingsObject.GetComponent<settings>().oneRoomMode == false)
        {
            for (int z = 0; z < 10; z++)
            {
                Instantiate(prefabPage, new Vector3(Random.Range(-radius, radius), height, Random.Range(-radius, radius)), Quaternion.identity);
            }
        }
        else
        {
            rotateStart = transform.rotation.y;
            rotatePleaseText.SetActive(true);
            countingDone();
        }

	}
	
	// Update is called once per frame
	void Update () {
        if (settingsObject.GetComponent<settings>().oneRoomMode == true && (f1 == 0 || f2 == 0 || f3 == 0 || f4 == 0))
            countingDone();
    }

    public void Gaming()
    {

        points++;
        if(points >= 10)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            if(points == 2)
                Instantiate(prefabSlenderman, new Vector3(-10, -10, -10), Quaternion.identity);

        tekst.transform.GetComponent<TextMesh>().text = points + "/10";
        
    }

    void countingDone()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit);
        //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward), Color.green);
        Debug.DrawLine(ray.origin, hit.point);

        if (f1 == 0)
        {
            if
              (
                ((transform.eulerAngles.y > rotateStart + 370 && transform.eulerAngles.y > rotateStart) || (transform.eulerAngles.y < rotateStart + 10 && transform.eulerAngles.y > rotateStart))
              )
                f1 = hit.distance;
        }

        if (f2 == 0)
        {
            if
              (
                (transform.eulerAngles.y > rotateStart + 80 && transform.eulerAngles.y < rotateStart + 100)
              )
                f2 = hit.distance;
        }

        if (f3 == 0)
        {
            if (transform.eulerAngles.y > rotateStart + 170 && transform.eulerAngles.y < rotateStart + 190)
                f3 = hit.distance;
        }

        if (f4 == 0)
        {
            if(
                (transform.eulerAngles.y > rotateStart + 260 && transform.eulerAngles.y < rotateStart + 280)
              )
            {
                f4 = hit.distance;
            }
        }

        if(f1 != 0 && f2 != 0 && f3 != 0 && f4 != 0)
        {
            rotatePleaseText.SetActive(false);
            for (int z = 0; z < 10; z++)
            {
                Instantiate(prefabPage, new Vector3(Random.Range(0 - f3, 0 + f1), height, Random.Range(0 - f4, 0 + f2)), Quaternion.identity);
            }
        }

    }
}
