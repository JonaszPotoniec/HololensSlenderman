using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour {

    public bool isClickable = true;
    public string functionName;
    public string functionArguments;
    public Material[] materials;
    public bool state;

    private GameObject settingsOBJ;

	// Use this for initialization
	void Start () {
        
        settingsOBJ = GameObject.Find("settings");

        if (isClickable)
        {
            if (state)
                transform.GetComponent<MeshRenderer>().sharedMaterial = materials[1];
            else
                transform.GetComponent<MeshRenderer>().sharedMaterial = materials[0];
        }

    }

    // Update is called once per frame
    void Update () {

    }

    void OnSelect()
    {
        if (isClickable)
        {
            state = !state;

            if(state)
                transform.GetComponent<MeshRenderer>().sharedMaterial = materials[1];
            else
                transform.GetComponent<MeshRenderer>().sharedMaterial = materials[0];
        }

        if(functionArguments == "&state")
        {
            settingsOBJ.SendMessageUpwards(functionName, state);
        }
        else
        {
            settingsOBJ.SendMessageUpwards(functionName, functionArguments);    
        }

        return;
    }
}
