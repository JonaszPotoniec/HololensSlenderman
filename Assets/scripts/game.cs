using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour {

    public int points = 0;
    public GameObject tekst;
    public GameObject prefabPage;
    public GameObject prefabSlenderman;
    public float radius = 20.0f;
    public float height = 0;

	// Use this for initialization
	void Start () {
        
        for (int z = 0; z < 10; z++)
        {
            Instantiate(prefabPage, new Vector3(Random.Range(-radius, radius), height, Random.Range(-radius, radius)), Quaternion.identity);
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
