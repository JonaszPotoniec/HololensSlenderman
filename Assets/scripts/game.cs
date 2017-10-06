using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour {

    public int points = 0;
    public GameObject tekst;
    public GameObject prefab;
    public float radius = 20.0f;

	// Use this for initialization
	void Start () {
        
        for (int z = 0; z < 10; z++)
        {
            Instantiate(prefab, new Vector3(Random.Range(-radius, radius), 0, Random.Range(-radius, radius)), Quaternion.identity);
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
        tekst.transform.GetComponent<TextMesh>().text = points + "/10";
        
    }

}
