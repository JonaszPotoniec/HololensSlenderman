using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour {

    public bool isClickable = true;
    public string functionName;
    public string functionArguments;
    public Material[] materials;


    private bool state;
    private GameObject settingsOBJ;

	// Use this for initialization
	void Start () {
        
        settingsOBJ = GameObject.Find("settings");

    }
	
	// Update is called once per frame
	void Update () {

    }

    void onSelect()
    {
        if (isClickable)
        {
            state = !state;

            if(state)
                transform.GetComponent<MeshRenderer>().sharedMaterial = materials[1];
            else
                transform.GetComponent<MeshRenderer>().sharedMaterial = materials[0];
        }

        settingsOBJ.SendMessageUpwards(functionName, functionArguments);
    }
}
